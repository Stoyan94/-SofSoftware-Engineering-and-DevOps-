Архитектура на Jenkins с подробности и реални примери
Jenkins е един от най-популярните инструменти за непрекъсната интеграция (CI) и непрекъснато разгръщане (CD). 
Той следва Master-Agent архитектура, която позволява ефективно разпределение на задачите между различни машини.

1. Архитектура на Jenkins

Jenkins може да бъде standalone (всичко работи на една машина) или distributed (разпределена архитектура).

Master-Agent модел
Jenkins Master – Основният сървър, който координира всички задачи.
Jenkins Agents – Изпълняват конкретни билдове и тестове, разтоварвайки Master-а.
Controller и Executors – Master-ът разпределя задачите, а Agent-ите ги изпълняват чрез Executors.

2. Компоненти на Jenkins и тяхната роля
Компонент	        Описание
Jenkins Master	    Контролира всички Jenkins агенти, управлява Jenkins jobs и осигурява уеб интерфейс.
Jenkins Agent	    Машина, която се използва за изпълнение на билдове и тестове.
Job (Задача)	    Конфигурирана CI/CD задача (например билдване на код, тестване или разгръщане).
Pipeline	        Декларативен или скриптов начин за описване на CI/CD процесите.
Workspace	        Директория, където Jenkins държи изходния код и файловете на даден билд.
Plugin (Разширение)	Позволява разширяване на функционалността (напр. Git, Docker, Kubernetes интеграции).

3. Пример за реална CI/CD интеграция с Jenkins
Сценарий: Автоматично билдване и разгръщане на ASP.NET Core приложение
Технологии в проекта:
✅ Jenkins – за автоматизация на билдове и разгръщане
✅ GitHub – като система за управление на версиите
✅ Docker – за контейнеризация на приложението
✅ Azure Kubernetes Service (AKS) – за разгръщане на контейнерите

Стъпки в процеса
1️⃣ Код промяна
Разработчикът прави промяна в ASP.NET Core проекта и я качва в GitHub.

2️⃣ Jenkins засича промяната
Използва GitHub Webhook, за да задейства автоматично билдване при нов комит.

3️⃣ Билдване на проекта
Jenkins Agent клонира репото, компилира кода и изпълнява тестове.

4️⃣ Създаване на Docker образ
Ако билдът е успешен, Jenkins изгражда Docker image:
docker build -t myapp:latest.

5️⃣ Публикуване на контейнера в Docker Hub
docker push myapp:latest

6️⃣ Разгръщане в Kubernetes Cluster
Jenkins актуализира Kubernetes конфигурацията и пуска новия контейнер:
kubectl apply -f deployment.yaml

7️⃣ Известяване на разработчиците
Jenkins изпраща съобщение в Slack или по имейл дали разгръщането е успешно.

4. Предимства на използването на Master-Agent архитектурата
Предимство	            Описание
Мащабируемост	        Позволява добавяне на допълнителни агенти за по-добро разпределение на задачите.
Гъвкавост	            Jenkins може да се стартира на Windows, Linux или macOS и да изпълнява различни среди за билдване.
Изолиране на билдове	Агенти могат да бъдат на различни машини и да изпълняват билдове паралелно.
Сигурност	            Намалява риска, тъй като билд процесите не се изпълняват директно на Master-а.




Jenkins Architecture with Detailed Examples
Jenkins is a popular Continuous Integration (CI) and Continuous Deployment (CD) tool. It follows a Master-Agent architecture, enabling efficient distribution of tasks across multiple machines.

1. Jenkins Architecture Overview
Jenkins can work in two modes:

Standalone Mode – Everything runs on a single machine.
Distributed Mode – Tasks are distributed across multiple agents.
Master-Agent Model
Jenkins Master – The central server that manages all tasks.
Jenkins Agents – Remote machines that execute builds and tests.
Controller and Executors – The master assigns tasks, and agents execute them through Executors.

2. Jenkins Components and Their Role

Component	    Description
Jenkins Master	Controls all Jenkins agents, manages Jenkins jobs, and provides the web UI.
Jenkins Agent	A remote machine that executes builds and tests.
Job	            A configured CI/CD task (e.g., building code, running tests, or deploying).
Pipeline	    A declarative or scripted way to define CI/CD processes.
Workspace	    A directory where Jenkins stores source code and build files.
Plugin	        Extends Jenkins functionality (e.g., Git, Docker, Kubernetes integration).


3. Real-World CI/CD Example Using Jenkins
Scenario: Automating the Build and Deployment of an ASP.NET Core Application
Technologies Used:
✅ Jenkins – Automates builds and deployment
✅ GitHub – Version control system
✅ Docker – Containerization
✅ Azure Kubernetes Service (AKS) – Deploys containers

Process Steps

1️⃣ Code Change
A developer pushes a new commit to GitHub.

2️⃣ Jenkins Detects the Change
A GitHub Webhook triggers the build process.

3️⃣ Building the Project
Jenkins Agent clones the repo, compiles the code, and runs tests.

4️⃣ Creating a Docker Image
If the build is successful, Jenkins builds a Docker image:

docker build -t myapp:latest.

5️⃣ Pushing the Container to Docker Hub
docker push myapp:latest

6️⃣ Deploying to Kubernetes Cluster
Jenkins updates the Kubernetes configuration and deploys the new container:
kubectl apply -f deployment.yaml

7️⃣ Notifying Developers
Jenkins sends a Slack or email notification about the deployment status.

4. Advantages of Master-Agent Architecture
Advantage	    Description
Scalability	    Easily add more agents to distribute workload.
Flexibility	    Supports multiple operating systems (Windows, Linux, macOS).
Build Isolation	Agents can run builds on separate machines in parallel.
Security	    Reduces risk since builds do not run directly on the master node.
