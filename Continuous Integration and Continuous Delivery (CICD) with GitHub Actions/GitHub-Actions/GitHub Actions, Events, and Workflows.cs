��������� ������

GitHub Actions, ������� � ������� ������
GitHub Actions � ����� ���������� �� �������������, ���������� � GitHub, ����� ��������� �� �������������� �� ������������� ��������� �� ������� �������� � �����������. 
��� ������ ��� CI/CD (������������ ���������� � ����������), �������� � �������� �������������� ������.

1. ������� �������
������	                    ��������
Workflow (������� �����)	YAML ����, ����� �������� ������� �� �������������. ������ �� �� ������ � ������.
Job (������)	            ����� �� ������, ����������� � ���� � ���� runner. �������� ����� �� �� ���������� �������������� ��� ���������.
Step (������)	            ������� ��� �������� � ������� �� ���� ������.
Action (��������)	        �������� ���������� ����� ����, ����� ��������� ��������� ������ (�������� �������� �� ��� ��� ���������� �� �������).
Runner (����������)	        ������, ����� ��������� �������� �����.
Event (�������)	            ������, ����� �������� �������� ����� (����. push, pull_request).
Context (��������)	        ��������� � ���������� �� ������� �� ����� �� ������������ �� �������� �����.

����� �������:
Secret (�����)	            ���������� ����������, ����� �� �������� �� ���������� �� ������������ ���������� (����. ������).
Artifact (��������)	        ����, �������� �� ����� �� ������������ �� �������� �����, ����� ���� �� ���� �������� ����� ������� ������.
Environment (�����)	        ����������, ����� �� ��������� �� ������������� �� �������� �����.
Service (������)	        ���������, ����� ���� �� ���� ��������� �� �������� �� ����������.


2. �������, ����� ��������� ������� ������
GitHub Actions �� ���������� �� �������. 
���-����� ��������� ��:

�������                     ��������
push	                    �������� ������� �����, ������ ����� ���� �������� � �����������.
pull_request	            ��������� �� ��� ��������, �������������� ��� �������� �������� �� pull request.
schedule	                �������� ������� ����� � ���������� ������ (cron ���������).
workflow_dispatch	        ��������� ����� ����������� �� ������� �����.
release	                    ��������� ��, ������ �� ��������� ���� �������.
issue_comment	            �������� ��� �������� � ����� issue.

����� �������:
pull_request_review	        ��������� �� ��� ���� �� pull request.
pull_request_review_comment	�������� ��� �������� � ���� �� pull request.
check_run	                ��������� �� ��� ���������� �� ��������.
check_suite	                �������� ��� ���������� �� ��������.
watch	                    ��������� �� ��� ���������� �� ���������.
create	                    �������� ��� ��������� �� branch ��� tag.
delete	                    ��������� �� ��� ��������� �� branch ��� tag.
fork	                    �������� ��� ��������� �� fork.
gollum	                    ��������� �� ��� �������� �� wiki.
label	                    �������� ��� �������� �� ������.
milestone	                ��������� �� ��� ��������� �� milestone.
project_card	            �������� ��� �������� �� ����� � ������.
project_column	            ��������� �� ��� �������� �� ������ � ������.
project	                    �������� ��� ��������� �� ������.
pull_request_target	        ��������� �� ��� �������� �� pull request �� fork.

3. �������� ������� �����
��� ���� ����� workflow (.github/workflows/example.yml), ����� �� ��������� ��� push ��� main:

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
-name: ��������� �� ����
        uses: actions / checkout@v3

      - name: ��������� �� Node.js
        uses: actions / setup - node@v3
        with:
          node - version: '16'

      - name: ����������� �� �����������
        run: npm install

      - name: ���������� �� �������
        run: npm test
4. ��������� �� �������� �����
��������� ����� �� ��������� ��� push � main.
��������� �� �� ubuntu-latest.
�������� ��������:
��������� �� ���� �� �����������.
��������� �� Node.js ������ 16.
����������� �� ����������� � npm install.
���������� �� ������� � npm test.


5. ��������� � �������������� ���������� �� ������
�� ������������ �������� �� ���������� ���������, �� ����� �� �� �������� ��������������:

yaml
jobs:
  job1:
runs - on: ubuntu - latest
    steps:
-run: echo "������ 1 ��������� ��"

  job2:
    runs - on: ubuntu - latest
    needs: job1  # ��������� �� ���� job1
    steps:
      -run: echo "������ 2 ��������� �� ���� ������ 1"
��� job2 �� ��������� ���� ���� ���� job1 ��������.



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

