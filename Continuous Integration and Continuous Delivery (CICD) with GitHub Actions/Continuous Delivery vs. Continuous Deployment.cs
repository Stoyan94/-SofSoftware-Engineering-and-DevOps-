Обяснение на български
Continuous Delivery (CD) vs. Continuous Deployment (CD)
И двете концепции са част от CI/CD процеса, но имат ключови разлики.

Характеристика	Continuous Delivery	Continuous Deployment
Какво прави?	Подготвя кода за пускане в продукция, но изисква ръчно одобрение.	Автоматично пуска всяка успешна промяна директно в продукция.
Човешка намеса?	Да – ръчен бутон за пускане.	Не – всяка успешна промяна се пуска автоматично.
Риск?	По-нисък, защото има ръчен контрол.	По-висок, защото грешки могат да стигнат до потребителите.
Използва се за?	Критични системи, банки, здравеопазване.	Уеб приложения, SaaS, мобилни приложения.

Пример за процеса

1️⃣ Continuous Delivery:
Разработчик качва код (push).
CI/CD система стартира тестове.
Ако тестовете минат успешно ➝ кодът се подготвя за деплой.
Човек натиска "Deploy" бутон, за да го пусне в продукция.


2️⃣ Continuous Deployment:
Разработчик качва код (push).
CI/CD система стартира тестове.
Ако тестовете минат успешно ➝ кодът автоматично се пуска в продукция.


Примерен GitHub Actions Pipeline за Continuous Deployment:
yaml
name: CD Pipeline

on: [push]

jobs:
deploy:
runs - on: ubuntu - latest

    steps:
-name: Checkout code
      uses: actions / checkout@v3

    - name: Setup.NET
      uses: actions / setup - dotnet@v3
      with:
        dotnet - version: '7.0'

    - name: Run tests
      run: dotnet test

    - name: Deploy to production
      if: success()
      run: echo "Deploying to production..."
✅ Този pipeline автоматично деплойва кода в продукция, ако тестовете минат успешно.

Заключение / Conclusion
Избери Continuous Delivery, ако искаш контрол върху пускането на новите версии.
Избери Continuous Deployment, ако искаш автоматично внедряване на всяка промяна.
💡 Continuous Delivery е по-подходящ за проекти с висока критичност, докато Continuous Deployment е перфектен за бързо развиващи се уеб приложения и SaaS решения.




Обяснение на английски
Continuous Delivery vs. Continuous Deployment
Both are part of the CI/CD process, but they have key differences.

Feature	Continuous Delivery	Continuous Deployment
What does it do?	Prepares code for release but requires manual approval.	Automatically releases every successful change to production.
Human intervention?	Yes – a manual deploy button.	No – every successful change is deployed automatically.
Risk?	Lower, since there's manual control.	Higher, as errors can reach users.
Used for?	Critical systems (banks, healthcare). Web apps, SaaS, mobile apps.

Process Example

1️⃣ Continuous Delivery:
Developer pushes code.
CI/CD system runs tests.
If tests pass ➝ code is prepared for deployment.
A human clicks "Deploy" to push it to production.

2️⃣ Continuous Deployment:
Developer pushes code.
CI/CD system runs tests.
If tests pass ➝ code is automatically deployed to production.

Example GitHub Actions Pipeline for Continuous Deployment:
yaml
name: CD Pipeline

on: [push]

jobs:
deploy:
runs - on: ubuntu - latest

    steps:
-name: Checkout code
      uses: actions / checkout@v3

    - name: Setup.NET
      uses: actions / setup - dotnet@v3
      with:
        dotnet - version: '7.0'

    - name: Run tests
      run: dotnet test

    - name: Deploy to production
      if: success()
      run: echo "Deploying to production..."
✅ This pipeline automatically deploys code to production if tests pass successfully.

Conclusion
Choose Continuous Delivery if you want control over when new versions are released.
Choose Continuous Deployment if you want every successful change to be deployed automatically.
💡 Continuous Delivery is more suitable for high-criticality projects, while Continuous Deployment is ideal for fast-evolving web applications and SaaS solutions.