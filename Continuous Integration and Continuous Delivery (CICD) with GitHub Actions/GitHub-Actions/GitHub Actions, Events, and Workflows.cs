Българска версия

GitHub Actions, Събития и Работни Потоци
GitHub Actions е мощен инструмент за автоматизация, интегриран в GitHub, който позволява на разработчиците да автоматизират работните си процеси директно в хранилищата. 
Той помага при CI/CD (непрекъсната интеграция и внедряване), тестване и различни автоматизирани задачи.

1. Основни понятия
Термин	                    Описание
Workflow (работен поток)	YAML файл, който определя процеса на автоматизация. Състои се от задачи и стъпки.
Job (задача)	            Набор от стъпки, изпълнявани в един и същи runner. Задачите могат да се изпълняват последователно или паралелно.
Step (стъпка)	            Команда или действие в рамките на една задача.
Action (действие)	        Повторно използваем кодов блок, който изпълнява конкретна задача (например проверка на код или стартиране на тестове).
Runner (изпълнител)	        Сървър, който изпълнява работния поток.
Event (събитие)	            Тригер, който стартира работния поток (напр. push, pull_request).
Context (контекст)	        Метаданни и информация за средата по време на изпълнението на работния поток.

Други понятия:
Secret (тайна)	            Криптирана променлива, която се използва за съхранение на чувствителна информация (напр. пароли).
Artifact (артефакт)	        Файл, създаден по време на изпълнението на работния поток, който може да бъде споделен между работни потоци.
Environment (среда)	        Променливи, които се използват за конфигуриране на работния поток.
Service (услуга)	        Контейнер, който може да бъде използван за тестване на приложения.


2. Събития, които стартират работни потоци
GitHub Actions се задействат от събития. 
Най-често срещаните са:

Събитие                     Описание
push	                    Стартира работен поток, когато комит бъде изпратен в хранилището.
pull_request	            Изпълнява се при отваряне, синхронизиране или повторно отваряне на pull request.
schedule	                Стартира работен поток в определени часове (cron синтаксис).
workflow_dispatch	        Позволява ръчно задействане на работен поток.
release	                    Изпълнява се, когато се публикува ново издание.
issue_comment	            Стартира при коментар в даден issue.

Други събития:
pull_request_review	        Изпълнява се при ревю на pull request.
pull_request_review_comment	Стартира при коментар в ревю на pull request.
check_run	                Изпълнява се при стартиране на проверка.
check_suite	                Стартира при стартиране на проверка.
watch	                    Изпълнява се при наблюдение на хранилище.
create	                    Стартира при създаване на branch или tag.
delete	                    Изпълнява се при изтриване на branch или tag.
fork	                    Стартира при създаване на fork.
gollum	                    Изпълнява се при редакция на wiki.
label	                    Стартира при добавяне на маркер.
milestone	                Изпълнява се при създаване на milestone.
project_card	            Стартира при добавяне на карта в проект.
project_column	            Изпълнява се при добавяне на колона в проект.
project	                    Стартира при създаване на проект.
pull_request_target	        Изпълнява се при отваряне на pull request от fork.

3. Примерен работен поток
Ето един прост workflow (.github/workflows/example.yml), който се изпълнява при push към main:

yaml
name: CI Workflow

on:
  push:
branches:
-main

jobs:
build:
runs - on: ubuntu - latest

    steps:
-name: Изтегляне на кода
        uses: actions / checkout@v3

      - name: Настройка на Node.js
        uses: actions / setup - node@v3
        with:
          node - version: '16'

      - name: Инсталиране на зависимости
        run: npm install

      - name: Стартиране на тестове
        run: npm test
4. Обяснение на работния поток
Работният поток се задейства при push в main.
Изпълнява се на ubuntu-latest.
Стъпките включват:
Изтегляне на кода от хранилището.
Настройка на Node.js версия 16.
Инсталиране на зависимости с npm install.
Стартиране на тестове с npm test.


5. Паралелно и последователно изпълнение на задачи
По подразбиране задачите се изпълняват паралелно, но можем да ги направим последователни:

yaml
jobs:
  job1:
runs - on: ubuntu - latest
    steps:
-run: echo "Задача 1 изпълнява се"

  job2:
    runs - on: ubuntu - latest
    needs: job1  # Изпълнява се след job1
    steps:
      -run: echo "Задача 2 изпълнява се след Задача 1"
Тук job2 се изпълнява само след като job1 приключи.



English Version
GitHub Actions, Events, and Workflows
GitHub Actions is a powerful automation tool integrated into GitHub that allows developers to automate software development workflows directly in their repositories. It helps with CI/CD (Continuous Integration and Continuous Deployment), testing, and various automated tasks.

1. Key Concepts
Term	    Description
Workflow	A YAML file that defines the automation process. It consists of jobs and steps.
Job	        A set of steps executed in the same runner. Jobs can run sequentially or in parallel.
Step	    A command or action inside a job.
Action	    A reusable unit of code that performs a task, like checking out code or running tests.
Runner	    A server that executes the workflow jobs.
Event	    A trigger that starts a workflow (e.g., push, pull_request).
Context 	Metadata and environment information available during workflow execution.

Other concepts:
Secret	    An encrypted variable used to store sensitive information (e.g., passwords).
Artifact	A file generated during workflow execution that can be shared between workflows.
Environment	Variables used to configure the workflow.
Service	    A container that can be used for testing applications.

2. Events that Trigger Workflows
GitHub Actions are triggered by events. Some of the most common ones are:

Event                 Description
push	              Triggers a workflow when a commit is pushed to the repository.
pull_request	      Runs when a pull request is opened, synchronized, or reopened.
schedule	          Triggers at specified times (cron syntax).
workflow_dispatch	  Allows manually triggering a workflow.
release	              Runs when a new release is published.
issue_comment         Triggers when someone comments on an issue.

Other events:
pull_request_review	  Runs when a pull request is reviewed.
pull_request_review_  comment Triggers when a comment is made on a pull request review.
check_run	          Runs when a check run is initiated.
check_suite	          Triggers when a check suite is initiated.
watch	              Runs when a repository is starred.
create	              Triggers when a branch or tag is created.
delete	              Runs when a branch or tag is deleted.
fork	              Triggers when a fork is created.
gollum	              Runs when a wiki page is edited.
label	              Triggers when a label is added.
milestone	          Runs when a milestone is created.
project_card	      Triggers when a card is added to a project.
project_column	      Runs when a column is added to a project.
project	              Triggers when a project is created.
pull_request_target	  Runs when a pull request is opened from a fork.

3. Example Workflow
Here is a simple workflow (.github/workflows/example.yml) that runs when code is pushed to the main branch:

yaml
name: CI Workflow

on:
  push:
branches:
-main

jobs:
build:
runs - on: ubuntu - latest

    steps:
-name: Checkout code
        uses: actions / checkout@v3

      - name: Setup Node.js
        uses: actions / setup - node@v3
        with:
          node - version: '16'

      - name: Install dependencies
        run: npm install

      - name: Run tests
        run: npm test

4. Explanation of the Workflow
The workflow is triggered when code is pushed to the main branch.
It runs on ubuntu-latest.
The steps:
Check out the repository code.
Set up Node.js version 16.
Install dependencies using npm install.
Run tests with npm test.

5. Running Jobs in Parallel and Sequentially
Jobs can run in parallel by default. However, if you want to run them sequentially, you can define dependencies:

yaml
Copy
Edit
jobs:
  job1:
runs - on: ubuntu - latest
    steps:
-run: echo "Job 1 running"

  job2:
    runs - on: ubuntu - latest
    needs: job1  # Runs after job1 completes
    steps:
      -run: echo "Job 2 running after Job 1"
Here, job2 runs only after job1 has completed.

