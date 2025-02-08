Българска версия:
Подробно обяснение на понятията в GitHub Actions

1. Workflow (Работен поток)
Какво е Workflow?
Работният поток (workflow) е YAML файл, който съдържа инструкции за автоматизация. 
Той определя кога, къде и как трябва да се изпълнят определени задачи в GitHub Actions. 
Всеки workflow може да съдържа една или повече задачи (jobs), които на свой ред имат стъпки (steps).

Къде се намира?
Workflow файловете се намират в директорията на вашето хранилище:

.github/workflows/
Примерен Workflow файл:

yaml
name: Example Workflow

on: push  # Изпълнява се при push към репото

jobs:
  example - job:
    runs - on: ubuntu - latest
    steps:
-name: Checkout код
        uses: actions / checkout@v3
      - name: Изпълнение на команда
        run: echo "Hello, World!"
Основни характеристики:
YAML формат
Съдържа jobs и steps
Задейства се от events
Изпълнява се в runner

2. Job (Задача)
Какво е Job?
Задачата (job) представлява група от стъпки, които се изпълняват заедно в един и същи runner. 
Един workflow може да съдържа няколко задачи, които могат да се изпълняват паралелно или последователно.

Пример:

yaml
jobs:
  build:
runs - on: ubuntu - latest
    steps:
-run: echo "Компилиране на кода"

  test:
    runs - on: ubuntu - latest
    needs: build  # Тази задача ще се изпълни след като "build" приключи
    steps:
      -run: echo "Изпълнение на тестове"
Характеристики:
Групиране на стъпки
Може да бъде самостоятелна или зависима (чрез needs)
Може да се изпълнява паралелно

3. Step (Стъпка)
Какво е Step?
Стъпката (step) е отделно действие, което се изпълнява в рамките на една задача. 
Тя може да бъде команда (run) или предварително създадено действие (uses).

Пример:

yaml

jobs:
  example - job:
    runs - on: ubuntu - latest
    steps:
-name: Изпълнение на shell команда
        run: echo "Изпълнявам команда"

      - name: Използване на предварително създадено действие
        uses: actions / setup - node@v3
        with:
          node - version: '16'
Характеристики:
Изпълняват се в последователен ред
Могат да бъдат run (изпълняване на команди)
Могат да използват actions

4. Action (Действие)
Какво е Action?
Action (действие) е предварително дефиниран кодов блок, който може да се използва повторно в различни стъпки на GitHub Actions. 
Действията могат да бъдат:
Официални GitHub Actions
Действия, създадени от общността
Собствени действия, дефинирани в репозиторий
Пример за действие:

yaml

steps:
  -name: Checkout код
    uses: actions / checkout@v3
Създаване на собствен Action:

yaml
steps:
  -name: Използване на собствено действие
    uses: ./ custom - action
Характеристики:
Повторно използваеми
Могат да бъдат локални или публични
Използват се чрез uses:


5.Runner(Изпълнител)
Какво е Runner?
Runner е сървърът, който изпълнява работния поток. GitHub предлага два вида:

GitHub - hosted runners(напр.ubuntu - latest, windows - latest, macos - latest)
Self - hosted runners(персонални машини, конфигурирани за изпълнение на workflow)
Пример:

yaml

jobs:
  example - job:
    runs - on: ubuntu - latest  # Изпълнение на Ubuntu сървър
Характеристики:

Определя къде ще се изпълнява кодът
Поддържа Linux, Windows и macOS
Може да бъде облачен или локален


6. Event (Събитие)
Какво е Event?
Събитие е тригер, който стартира изпълнението на работен поток. GitHub предоставя много събития, като:

push – когато код бъде изпратен в репото
pull_request – когато PR бъде създаден или обновен
schedule – изпълнение по разписание
workflow_dispatch – ръчно задействане
Пример:

yaml

on:
  push:
branches:
-main
Характеристики:
Определя кога ще се стартира workflow
Може да бъде автоматично или ръчно
Поддържа cron синтаксис

7. Context (Контекст)
Какво е Context?
Контекстът съдържа информация за работния поток, като име на клон, потребител, commit ID и други метаданни. 
Използва се за достъп до динамични данни в работните потоци.

Пример за използване на контекст:

yaml

jobs:
  example - job:
    runs - on: ubuntu - latest
    steps:
-run: echo "Изпълнява се в клон ${{ github.ref }}"
Важни контексти:

${ { github } } – съдържа информация за събитието и хранилището
${{ runner }} – съдържа информация за сървъра, на който се изпълнява workflow
${{ env }} – съдържа променливи на средата
Характеристики:
Предоставя метаданни
Използва се чрез ${{ }}
Позволява динамични стойности

Заключение
GitHub Actions предлага мощна автоматизация, базирана на workflows, jobs, steps и actions. 
Разбирането на тези основни понятия е важно за ефективното използване на CI/CD процеси в GitHub.







English Version:
Detailed Explanation of GitHub Actions Concepts

1. Workflow
What is a Workflow?
A workflow is a YAML file that defines the automation process in GitHub Actions. 
It specifies when, where, and how certain jobs should run in response to events. 
Each workflow consists of one or more jobs, which contain steps that define the actions to be executed.

Where is it located?
Workflow files are stored in the repository under:

.github/workflows/
Example Workflow file:

yaml

name: Example Workflow

on: push  # Runs when code is pushed to the repository

jobs:
  example - job:
    runs - on: ubuntu - latest
    steps:
-name: Checkout code
        uses: actions / checkout@v3
      - name: Run a command
        run: echo "Hello, World!"
Key Characteristics:
Written in YAML format
Contains jobs and steps
Triggered by events
Runs on a runner

2. Job
What is a Job?
A job is a collection of steps that run together in a single runner. 
A workflow can contain multiple jobs, which can either run in parallel or sequentially (using dependencies).

Example:

yaml

  build:
runs - on: ubuntu - latest
    steps:
-run: echo "Building the code"

  test:
    runs - on: ubuntu - latest
    needs: build  # This job runs only after "build" is completed
    steps:
      -run: echo "Running tests"
Key Characteristics:
Groups multiple steps
Can be independent or dependent (needs)
Supports parallel and sequential execution

3. Step
What is a Step?
A step is an individual action executed within a job. 
It can either be a command (run) or a predefined action (uses).

Example:

yaml

jobs:
  example - job:
    runs - on: ubuntu - latest
    steps:
-name: Run a shell command
        run: echo "Executing a command"

      - name: Use a prebuilt action
        uses: actions / setup - node@v3
        with:
          node - version: '16'
Key Characteristics:

Executed in sequential order
Can be run commands
Can use predefined or custom actions

4. Action
What is an Action?
An action is a reusable block of code that performs a specific task in a GitHub Actions workflow. Actions can be:

Official GitHub Actions
Community-created actions
Custom actions defined in a repository
Example of using an action:

yaml

steps:
  -name: Checkout code
    uses: actions / checkout@v3
Creating a custom action:

yaml
Copy
Edit
steps:
  -name: Use a custom action
    uses: ./ custom - action
Key Characteristics:

Reusable across workflows
Can be local or public
Used with uses: in steps

5. Runner
What is a Runner?
A runner is a server that executes the workflow. GitHub provides two types of runners:

GitHub - hosted runners(e.g., ubuntu - latest, windows - latest, macos - latest)
Self - hosted runners(custom machines configured to run workflows)
Example:

yaml

jobs:
  example - job:
    runs - on: ubuntu - latest  # Runs on an Ubuntu server
Key Characteristics:

Defines where the workflow runs
Supports Linux, Windows, and macOS
Can be cloud-based or self-hosted

6. Event
What is an Event?
An event is a trigger that starts the execution of a workflow. GitHub provides various events, including:

push – when code is pushed to the repository
pull_request – when a PR is created or updated
schedule – runs on a specified schedule
workflow_dispatch – manually triggered execution
Example:

yaml
on:
  push:
branches:
-main
Key Characteristics:

Defines when a workflow will start
Can be automatic or manual
Supports cron syntax

7. Context
What is Context?
Context provides metadata and environmental information about the workflow execution, such as branch name, user, commit ID, and more. It is used to dynamically access data in workflows.

Example using context:

yaml
Copy
Edit
jobs:
  example - job:
    runs - on: ubuntu - latest
    steps:
-run: echo "Running on branch ${{ github.ref }}"
Important Contexts:

${ { github } } – contains information about the event and repository
${{ runner }} – contains information about the runner machine
${{ env }} – contains environment variables
Key Characteristics:

Provides metadata
Used with ${{ }}
Allows dynamic values


Conclusion
GitHub Actions provides powerful automation through workflows, jobs, steps, and actions. 
Understanding these key concepts is essential for efficiently using CI/ CD processes in GitHub.