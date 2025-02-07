CI / CD(Continuous Integration / Continuous Deployment) е практика в софтуерната разработка, 
    която автоматизира процеса на изграждане, тестване и внедряване на код. 
    Това позволява по-бързо и надеждно пускане на нови версии на приложения.

Основни концепции на CI/CD
Термин	                            Описание
Continuous Integration (CI)	        Разработчиците често сливат (merge-ват) кода си в централизирано хранилище (например GitHub). Всеки commit стартира автоматичен build и тестове.
Continuous Deployment (CD)	        След успешни тестове, кодът автоматично се внедрява в production среда.
Continuous Delivery	                Подобно на Continuous Deployment, но с ръчен тригер за финално внедряване.
Pipeline	                        Автоматизиран процес, който включва стъпки като билдване, тестване и деплойване.
Orchestration Tools	                Инструменти като GitHub Actions, Jenkins, GitLab CI/CD се използват за автоматизацията на тези процеси.


Пример със GitHub Actions
GitHub Actions е вграден инструмент за CI/CD в GitHub, 
който позволява автоматично изпълнение на различни стъпки (jobs) в отговор на събития (events) като push, pull request и др.

Стъпки за създаване на CI/CD pipeline с GitHub Actions:

Създай.github / workflows / main.yml в твоето хранилище.
Добави следния код:

yaml
name: CI / CD Pipeline

on:
  push:
branches:
-main
  pull_request:
branches:
-main

jobs:
build:
runs - on: ubuntu - latest

    steps:
-name: Checkout repository
        uses: actions / checkout@v4

      - name: Setup.NET
        uses: actions / setup - dotnet@v3
        with:
          dotnet - version: '8.0.x'

      - name: Restore dependencies
        run: dotnet restore

      - name: Build project
        run: dotnet build --configuration Release --no-restore

      - name: Run tests
        run: dotnet test --no-restore --verbosity normal

Какво прави този workflow?
Изпълнява се при push и pull request към main.
Стартира job-а build, който се изпълнява на ubuntu-latest.
Клонира хранилището.
Настройва .NET 8.
Възстановява зависимостите (dotnet restore).
Компилира проекта (dotnet build).
Изпълнява тестове (dotnet test).
💡 Ако някоя от тези стъпки се провали, GitHub ще спре изпълнението и ще ти даде грешка.



Пример с Jenkins
Jenkins е популярен CI/CD инструмент, който може да се използва за автоматизиране на build, тестове и deployment.

Стъпки за настройка на CI/CD pipeline с Jenkins
Инсталирай Jenkins на твоя сървър (или използвай Docker).
Инсталирай необходими плъгини: "Pipeline", "Git", ".NET SDK".
Създай нов pipeline job.

Добави следния код в Jenkinsfile:

groovy
pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/потребител/репо.git'
            }
        }

        stage('Setup .NET') {
    steps {
        sh 'dotnet --version'
            }
}

stage('Restore Dependencies') {
    steps {
        sh 'dotnet restore'
            }
}

stage('Build') {
    steps {
        sh 'dotnet build --configuration Release --no-restore'
            }
}

stage('Test') {
    steps {
        sh 'dotnet test --no-restore --verbosity normal'
            }
}

stage('Deploy') {
    steps {
        echo 'Deployment step here...'
            }
}
    }
}

Какво прави този pipeline?
Етап	        Действие
Checkout	    Изтегля кода от GitHub.
Setup .NET	    Проверява наличието на .NET.
Restore Dependencies	Възстановява NuGet пакетите.
Build	        Компилира проекта.
Test	        Изпълнява unit тестове.
Deploy	        (Опционално) Деплойва проекта.
💡 Jenkins изисква по-сложна конфигурация, но е по-гъвкав от GitHub Actions.

Сравнение между GitHub Actions и Jenkins
Фактор	            GitHub Actions	            Jenkins
Интеграция	        Вграден в GitHub	        Самостоятелен (трябва да се хоства)
Лесна настройка	    Лесен (YAML файлове)	    Изисква повече конфигурация
Гъвкавост	        По-малко плъгини	        Огромна екосистема от плъгини
Сигурност	        Управлява се от GitHub	    Изисква ръчно управление на правата
Разходи	            Безплатен за малки проекти	Може да изисква хостинг ресурси

Реален сценарий от работна среда

Ситуация:
Работиш по C# уеб приложение и искаш да:

Автоматично билдваш кода при всяка промяна.
Стартираш unit тестове.
Деплойваш приложението в Azure след успешен build.
Решение с GitHub Actions:

Добавяш pipeline в .github/workflows/deploy.yml:

yaml
name: CI / CD Pipeline

on:
  push:
branches:
-main

jobs:
build - and - deploy:
    runs - on: ubuntu - latest

    steps:
-name: Checkout repository
        uses: actions / checkout@v4

      - name: Setup.NET
        uses: actions / setup - dotnet@v3
        with:
          dotnet - version: '8.0.x'

      - name: Restore dependencies
        run: dotnet restore

      - name: Build project
        run: dotnet build --configuration Release --no-restore

      - name: Run tests
        run: dotnet test --no-restore --verbosity normal

      - name: Deploy to Azure
        run: |
          az login--service - principal - u ${ { secrets.AZURE_USERNAME } }
-p ${ { secrets.AZURE_PASSWORD } }
--tenant ${ { secrets.AZURE_TENANT } }
az webapp deploy --name myapp --resource-group mygroup --src-path ./publish.zip


Резултат:
🔹 Всеки push към main билдва, тества и деплойва приложението.
🔹 Ако build или тестовете се провалят, deployment няма да се случи.

Заключение
CI/CD автоматизира досадните задачи по билдване, тестване и деплойване, като прави процеса по-надежден и бърз.

За малки проекти в GitHub → GitHub Actions.
За големи и сложни проекти → Jenkins.




ENGLISH:

CI / CD Explained in Detail with GitHub Actions and Jenkins
CI/CD (Continuous Integration/Continuous Deployment) is a software development practice that automates the process of building, testing, and deploying code. This enables faster and more reliable releases.

Key Concepts of CI/CD
Term	                        Description
Continuous Integration (CI)	    Developers frequently merge their code into a central repository (e.g., GitHub). Each commit triggers an automated build and tests.
Continuous Deployment (CD)	    After successful tests, the code is automatically deployed to production.
Continuous Delivery	            Similar to Continuous Deployment, but with a manual trigger for the final deployment.
Pipeline	                    An automated process that includes steps such as building, testing, and deploying.
Orchestration Tools	            Tools like GitHub Actions, Jenkins, and GitLab CI/CD automate these processes.

Example with GitHub Actions
GitHub Actions is a built-in CI/CD tool in GitHub that allows automatic execution of various steps (jobs) in response to events like push, pull requests, etc.

Steps to Create a CI/CD Pipeline with GitHub Actions:
Create.github / workflows / main.yml in your repository.
Add the following code:

yaml
name: CI / CD Pipeline

on:
  push:
branches:
-main
  pull_request:
branches:
-main

jobs:
build:
runs - on: ubuntu - latest

    steps:
-name: Checkout repository
        uses: actions / checkout@v4

      - name: Setup.NET
        uses: actions / setup - dotnet@v3
        with:
          dotnet - version: '8.0.x'

      - name: Restore dependencies
        run: dotnet restore

      - name: Build project
        run: dotnet build --configuration Release --no-restore

      - name: Run tests
        run: dotnet test --no-restore --verbosity normal
What Does This Workflow Do?
Triggers on push and pull request to main.
Starts the build job, which runs on ubuntu-latest.
Clones the repository.
Sets up .NET 8.
Restores dependencies (dotnet restore).
Builds the project (dotnet build).
Runs tests (dotnet test).
💡 If any of these steps fail, GitHub stops execution and provides an error.

Example with Jenkins
Jenkins is a popular CI/CD tool used for automating build, testing, and deployment processes.

Steps to Set Up a CI/CD Pipeline with Jenkins
Install Jenkins on your server (or use Docker).
Install required plugins: "Pipeline", "Git", ".NET SDK".
Create a new pipeline job.

Add the following code to Jenkinsfile:

groovy
pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/your-user/repo.git'
            }
        }

        stage('Setup .NET') {
            steps {
                sh 'dotnet --version'
            }
        }

        stage('Restore Dependencies') {
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build --configuration Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test --no-restore --verbosity normal'
            }
        }

        stage('Deploy') {
            steps {
                echo 'Deployment step here...'
            }
        }
    }
}
What Does This Pipeline Do?
Stage	            Action
Checkout	        Clones the code from GitHub.
Setup .NET	        Checks if .NET is installed.
Restore             Dependencies	Restores NuGet packages.
Build	            Compiles the project.
Test	            Runs unit tests.
Deploy  (Optional)  Deploys the project.


💡 Jenkins requires more configuration but is more flexible than GitHub Actions.

Comparison Between  GitHub Actions and      Jenkins
Factor	            GitHub Actions	        Jenkins
Integration	        Built into GitHub	    Standalone (requires hosting)
Ease of Setup	    Easy (YAML files)	    Requires more configuration
Flexibility	        Fewer plugins	        Extensive plugin ecosystem
Security	        Managed by GitHub	    Requires manual permission management
Cost	            Free for small projects	May require hosting costs


Real-World Scenario
Situation:
You are working on a C# web application and want to:

Automatically build the code on each change.
Run unit tests.
Deploy the application to Azure after a successful build.
Solution with GitHub Actions:

Add the following pipeline to .github/workflows/deploy.yml:

yaml
name: CI / CD Pipeline

on:
  push:
branches:
-main

jobs:
build - and - deploy:
    runs - on: ubuntu - latest

    steps:
-name: Checkout repository
        uses: actions / checkout@v4

      - name: Setup.NET
        uses: actions / setup - dotnet@v3
        with:
          dotnet - version: '8.0.x'

      - name: Restore dependencies
        run: dotnet restore

      - name: Build project
        run: dotnet build --configuration Release --no-restore

      - name: Run tests
        run: dotnet test --no-restore --verbosity normal

      - name: Deploy to Azure
        run: |
          az login--service - principal - u ${ { secrets.AZURE_USERNAME } }
-p ${ { secrets.AZURE_PASSWORD } }
--tenant ${ { secrets.AZURE_TENANT } }
az webapp deploy --name myapp --resource-group mygroup --src-path ./publish.zip
Result:
🔹 Every push to main builds, tests, and deploys the application.
🔹 If the build or tests fail, deployment will not happen.

Conclusion
CI/CD automates tedious tasks such as building, testing, and deployment, making the process more reliable and faster.

For small projects on GitHub → GitHub Actions.
For large and complex projects → Jenkins.