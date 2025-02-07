Околни среди в софтуерната разработка

Среда	                        Какво се случва тук?	                                                 Пример
Development (Разработка)	    Програмистът пише и качва код в Git.	                                 git commit -m "Добавих нова функционалност"
Testing     (Тестване)	        Автоматизирани тестове проверяват дали кодът работи правилно.	         dotnet test
Staging     (Подготвителна)	    Кодът се качва в среда, подобна на продукционната, за крайни тестове.	 docker-compose up
Production  (Продакшън)	        Кодът се внедрява за реални потребители.	                             kubectl apply -f deployment.yaml

Стъпки на изпълнение за всяка среда

1. Development (Разработка)
Програмистът пише код и го качва в Git.

Примерен код (C#)
csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

Команди за изпълнение:
git add .
git commit -m "Добавих нова функционалност"
git push origin main


2. Testing (Тестване)
Автоматизираните тестове проверяват дали кодът работи правилно.

Примерен тест (C# NUnit)
csharp
[Test]
public void Add_TwoNumbers_ReturnsSum()
{
    var calc = new Calculator();
    int result = calc.Add(2, 3);
    Assert.AreEqual(5, result);
}

Команди за изпълнение:
dotnet test



3. Staging (Подготвителна среда)
Ако тестовете са успешни, кодът се качва в среда, подобна на продукционната.

Примерна Docker конфигурация:
yaml
version: '3'
services:
app:
image: myapp: latest
ports:
      -"5000:5000"

Команди за изпълнение:
docker-compose up


4. Production (Продакшън)
Ако всичко е наред, кодът се внедрява за реални потребители.

Команди за изпълнение:
kubectl apply -f deployment.yaml


Обобщение
Разработка – Пишете код и го качвате в Git.
Тестване – Изпълнявате автоматизирани тестове, за да проверите кода.
Подготвителна среда – Качвате кода в тестова среда преди продукцията.
Продакшън – Качвате кода за реални потребители.
CI/CD автоматизира тези стъпки, което прави разработката на софтуер по-бърза и по-надеждна. 🚀





ENGLISH:

CI/CD and Software Development Environments 

Environment	            What happens here?	                                                      Example
Development	            The developer writes and commits code to Git.	                          git commit -m "Added new feature"
Testing	                Automated tests check if the code is correct.	                          dotnet test
Staging	                The code is deployed to a production-like environment for final testing.  docker-compose up
Production	            The code is deployed for real users.	                                  kubectl apply -f deployment.yaml

Execution Steps for Each Environment

1. Development
The developer writes code and commits it to Git.

Example Code (C#)
csharp
Copy
Edit
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
Commands:
git add .
git commit -m "Added new feature"
git push origin main


2. Testing
Automated tests check if the code works correctly.
Example Test (C# NUnit)

[Test]
public void Add_TwoNumbers_ReturnsSum()
{
    var calc = new Calculator();
    int result = calc.Add(2, 3);
    Assert.AreEqual(5, result);
}
Commands:
dotnet test


3. Staging
If tests pass, the code is deployed to a production-like environment.

Example Docker Configuration:
yaml
version: '3'
services:
app:
image: myapp: latest
ports:
      -"5000:5000"
Commands:
docker-compose up


4. Production
If everything is correct, the code is deployed for real users.
Commands:
kubectl apply -f deployment.yaml


Summary
Development – Write code and push to Git.
Testing – Run automated tests to check the code.
Staging – Deploy to a test environment before production.
Production – Deploy for real users.
CI/CD automates these steps, making software development faster and more reliable. 🚀