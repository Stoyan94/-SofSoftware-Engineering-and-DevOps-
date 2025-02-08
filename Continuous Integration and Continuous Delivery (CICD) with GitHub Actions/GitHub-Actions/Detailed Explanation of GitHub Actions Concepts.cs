��������� ������:
�������� ��������� �� ��������� � GitHub Actions

1. Workflow (������� �����)
����� � Workflow?
��������� ����� (workflow) � YAML ����, ����� ������� ���������� �� �������������. 
��� �������� ����, ���� � ��� ������ �� �� �������� ���������� ������ � GitHub Actions. 
����� workflow ���� �� ������� ���� ��� ������ ������ (jobs), ����� �� ���� ��� ���� ������ (steps).

���� �� ������?
Workflow ��������� �� ������� � ������������ �� ������ ���������:

.github/workflows/
�������� Workflow ����:

yaml
name: Example Workflow

on: push  # ��������� �� ��� push ��� ������

jobs:
  example - job:
    runs - on: ubuntu - latest
    steps:
-name: Checkout ���
        uses: actions / checkout@v3
      - name: ���������� �� �������
        run: echo "Hello, World!"
������� ��������������:
YAML ������
������� jobs � steps
��������� �� �� events
��������� �� � runner

2. Job (������)
����� � Job?
�������� (job) ������������ ����� �� ������, ����� �� ���������� ������ � ���� � ���� runner. 
���� workflow ���� �� ������� ������� ������, ����� ����� �� �� ���������� ��������� ��� ��������������.

������:

yaml
jobs:
  build:
runs - on: ubuntu - latest
    steps:
-run: echo "����������� �� ����"

  test:
    runs - on: ubuntu - latest
    needs: build  # ���� ������ �� �� ������� ���� ���� "build" ��������
    steps:
      -run: echo "���������� �� �������"
��������������:
��������� �� ������
���� �� ���� ������������� ��� �������� (���� needs)
���� �� �� ��������� ���������

3. Step (������)
����� � Step?
�������� (step) � ������� ��������, ����� �� ��������� � ������� �� ���� ������. 
�� ���� �� ���� ������� (run) ��� ������������� ��������� �������� (uses).

������:

yaml

jobs:
  example - job:
    runs - on: ubuntu - latest
    steps:
-name: ���������� �� shell �������
        run: echo "���������� �������"

      - name: ���������� �� ������������� ��������� ��������
        uses: actions / setup - node@v3
        with:
          node - version: '16'
��������������:
���������� �� � �������������� ���
����� �� ����� run (����������� �� �������)
����� �� ��������� actions

4. Action (��������)
����� � Action?
Action (��������) � ������������� ��������� ����� ����, ����� ���� �� �� �������� �������� � �������� ������ �� GitHub Actions. 
���������� ����� �� �����:
��������� GitHub Actions
��������, ��������� �� ���������
��������� ��������, ���������� � �����������
������ �� ��������:

yaml

steps:
  -name: Checkout ���
    uses: actions / checkout@v3
��������� �� �������� Action:

yaml
steps:
  -name: ���������� �� ��������� ��������
    uses: ./ custom - action
��������������:
�������� �����������
����� �� ����� ������� ��� ��������
��������� �� ���� uses:


5.Runner(����������)
����� � Runner?
Runner � ��������, ����� ��������� �������� �����. GitHub �������� ��� ����:

GitHub - hosted runners(����.ubuntu - latest, windows - latest, macos - latest)
Self - hosted runners(���������� ������, ������������� �� ���������� �� workflow)
������:

yaml

jobs:
  example - job:
    runs - on: ubuntu - latest  # ���������� �� Ubuntu ������
��������������:

�������� ���� �� �� ��������� �����
�������� Linux, Windows � macOS
���� �� ���� ������� ��� �������


6. Event (�������)
����� � Event?
������� � ������, ����� �������� ������������ �� ������� �����. GitHub ���������� ����� �������, ����:

push � ������ ��� ���� �������� � ������
pull_request � ������ PR ���� �������� ��� �������
schedule � ���������� �� ����������
workflow_dispatch � ����� �����������
������:

yaml

on:
  push:
branches:
-main
��������������:
�������� ���� �� �� �������� workflow
���� �� ���� ����������� ��� �����
�������� cron ���������

7. Context (��������)
����� � Context?
���������� ������� ���������� �� �������� �����, ���� ��� �� ����, ����������, commit ID � ����� ���������. 
�������� �� �� ������ �� ��������� ����� � ��������� ������.

������ �� ���������� �� ��������:

yaml

jobs:
  example - job:
    runs - on: ubuntu - latest
    steps:
-run: echo "��������� �� � ���� ${{ github.ref }}"
����� ���������:

${ { github } } � ������� ���������� �� ��������� � �����������
${{ runner }} � ������� ���������� �� �������, �� ����� �� ��������� workflow
${{ env }} � ������� ���������� �� �������
��������������:
���������� ���������
�������� �� ���� ${{ }}
��������� ��������� ���������

����������
GitHub Actions �������� ����� �������������, �������� �� workflows, jobs, steps � actions. 
����������� �� ���� ������� ������� � ����� �� ����������� ���������� �� CI/CD ������� � GitHub.







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

push � when code is pushed to the repository
pull_request � when a PR is created or updated
schedule � runs on a specified schedule
workflow_dispatch � manually triggered execution
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

${ { github } } � contains information about the event and repository
${{ runner }} � contains information about the runner machine
${{ env }} � contains environment variables
Key Characteristics:

Provides metadata
Used with ${{ }}
Allows dynamic values


Conclusion
GitHub Actions provides powerful automation through workflows, jobs, steps, and actions. 
Understanding these key concepts is essential for efficiently using CI/ CD processes in GitHub.