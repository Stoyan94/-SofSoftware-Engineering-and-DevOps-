Обяснение на български
CT (Continuous Testing) означава непрекъснато тестване – практика, при която автоматизираните тестове се изпълняват на всяка стъпка от разработката. 
Целта е да се откриват грешки възможно най-рано, вместо да се чака края на проекта.

Как работи CT?
1️⃣ Разработчикът прави промяна в кода (commit/push).
2️⃣ CI/CD системата (Jenkins, GitHub Actions, GitLab CI) автоматично стартира тестове.

3️⃣ Различни нива на тестване:
Unit тестове – проверяват малки части от кода (функции, методи).
Integration тестове – гарантират, че различни модули работят заедно.
End-to-End тестове – симулират реалното използване на софтуера.

4️⃣ Ако тестовете преминат успешно – кодът може да продължи към следващия етап.
5️⃣ Ако тестовете се провалят – грешката се поправя веднага.

Пример за автоматизирано CT в CI/CD pipeline (GitHub Actions)

yaml
name: CI Pipeline

on: [push, pull_request]

jobs:
test:
runs - on: ubuntu - latest

    steps:
-name: Checkout code
      uses: actions / checkout@v3

    - name: Setup.NET
      uses: actions / setup - dotnet@v3
      with:
        dotnet - version: '7.0'

    - name: Run unit tests
      run: dotnet test
✅ Този pipeline автоматично изпълнява тестовете при всяко качване на код в хранилището.



Обяснение на английски
CT (Continuous Testing) is a practice where automated tests run at every stage of software development. 
The goal is to catch bugs as early as possible instead of waiting until the end of the project.

How does CT work?

1️⃣ A developer makes a code change (commit/push).
2️⃣ A CI/CD system (Jenkins, GitHub Actions, GitLab CI) automatically triggers tests.
3️⃣ Different levels of testing:

Unit tests – check small pieces of code (functions, methods).
Integration tests – ensure different components work together.
End-to-End tests – simulate real-world usage of the software.
4️⃣ If tests pass successfully – the code moves forward.
5️⃣ If tests fail – the issue is fixed immediately.

Example of automated CT in a CI/CD pipeline (GitHub Actions)

yaml
name: CI Pipeline

on: [push, pull_request]

jobs:
test:
runs - on: ubuntu - latest

    steps:
-name: Checkout code
      uses: actions / checkout@v3

    - name: Setup.NET
      uses: actions / setup - dotnet@v3
      with:
        dotnet - version: '7.0'

    - name: Run unit tests
      run: dotnet test
✅ This pipeline automatically runs tests whenever code is pushed to the repository.