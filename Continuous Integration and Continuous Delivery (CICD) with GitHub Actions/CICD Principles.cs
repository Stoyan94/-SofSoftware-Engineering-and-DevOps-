CI / CD Принципи:
Едно източно хранилище(Source Repository)
Описание: Това е единно хранилище(например Git репозиториум), в който се съхраняват всички файлове, нужни за изграждане на проекта. 
Това включва не само кода, но и скриптове за миграция на базата данни, библиотеки и конфигурационни файлове.

Пример в реална среда:
Имаме Git репозиториум, който съдържа всички изходни кодове на приложение, както и SQL скриптове за създаване на таблици в базата данни.
В този репозиториум може да има различни папки, например:
src / за изходния код,
database/ за скриптове за база данни,
libs/ за външни библиотеки,
scripts/ за различни автоматизирани процеси.

Примерна структура на хранилището:
my_project/
├── src/
│   └── main/
├── database/
│   └── migrations/
├── libs/
└── scripts/


Чести итерации и check-ins в основния клон (Frequent Iterations and Check-ins to the Main Branch)

Описание: Честото качване на малки промени в основния клон (main branch) позволява бързо интегриране на нови функции и намалява риска от конфликти, когато се обединяват промените на различни разработчици.

Пример в реална среда:
В ежедневната работа на junior developer може да се наложи да добавя нови малки функции или да поправя бъгове в приложение.
След като завърши работа по определена задача, той трябва бързо да качи тези промени в основния клон, за да ги интегрира с останалата част от екипа.

Например: работите по добавяне на нова страница в сайта и след като завършите с изграждането й, ще качите промените в основния клон с коментар “Добавена е новата страница”.
Използване на малки сегменти от код (Small Segments of Code)
Описание: Вместо да се правят големи промени, които ще бъдат интегрирани на по-късен етап, е по-добре да се работи с малки части от код, които често се обединяват с основния клон. 
Това намалява риска от грешки и конфликтни ситуации.

Пример в реална среда:
Junior developer започва да добавя нова функционалност към сайт (например форма за вход), но вместо да изгражда цялата форма за вход наведнъж, 
той може да добави малки функционалности като полета за потребителско име и парола и да ги качи в основния клон. 
Това помага за по-лесно тестване и интеграция.


Автоматизирани и само-тестиращи се билдове (Automated and Self-Testing Builds)
Описание: Когато качите промени в основния клон, е важно тези промени автоматично да преминат през тестове, за да се уверите, че не са нарушили нищо в проекта. 
Това често се прави с помощта на CI/CD инструменти, като Jenkins, GitLab CI, CircleCI и други.
Пример в реална среда:
След като качите промените, CI/CD системата автоматично ще започне процеса на билдване (създаване на компилирана версия на приложението) и тестване на новите функции, за да гарантира, че всичко работи както трябва.
Например: когато качите промени в репозиториума, системата автоматично ще стартира тестове за проверка на новата функционалност (например, дали форма за вход работи коректно).

Таблица на CI/CD процесите:
Принцип                           Описание	                                                            Пример
Едно източно хранилище	          Всичко нужно за билдване е в едно хранилище.	                        Git репозиториум с код, бази данни, скриптове.
Чести итерации	                  Малки промени, които често се качват в основния клон.	                Честото качване на малки промени в основния клон.
Малки сегменти от код	          Работа с малки части от код, които се качват редовно.	                Добавяне на функционалности на малки стъпки.
Автоматизирани билдове и тестове  Използване на CI/CD инструменти за автоматизация на тестовете.	    Jenkins или GitLab стартиране на тестове след commit.








CI/CD Principles (in English):
Single Source Repository

Description: This is a central repository(e.g., Git) where all the files needed to build the project are stored. It contains not only the source code but also database scripts, libraries, and configuration files.
Example in a real-world scenario:
You have a Git repository with the application code and SQL migration scripts stored in it.

The repository may have folders like:
src / for source code,
database/ for database scripts,
libs/ for external libraries,
scripts/ for automation tasks.
Example of repository structure:

css
Copy
Edit
my_project /
├── src /
│   └── main /
├── database /
│   └── migrations /
├── libs /
└── scripts /

Frequent Iterations and Check - ins to the Main Branch
Description: Frequently pushing small changes to the main branch allows for faster integration of new features and reduces the risk of conflicts when merging different developers’ changes.
Example in a real - world scenario:
As a junior developer, you may add small features or fix bugs in the application.After completing a task, you quickly push the changes to the main branch to integrate with the rest of the team’s work.
For example: you're adding a new page to a website, and after you finish building it, you push your changes to the main branch with a comment like “New page added.”

Small Segments of Code
Description: Instead of making large changes and integrating them later, it is better to work with small segments of code that are frequently merged into the main branch.This reduces the risk of errors and conflicts.
Example in a real - world scenario:
As a junior developer, you start by adding a new login form.
Instead of building the whole login form at once, you can first add small functionalities like username and password fields, and push them to the main branch.This helps in testing and integration.

Automated and Self - Testing Builds
Description: When you push your changes, it is important that they automatically go through tests to ensure nothing in the project is broken.This is usually handled by CI / CD tools like Jenkins, GitLab CI, CircleCI, etc.
Example in a real - world scenario:
Once you push your changes, the CI / CD system automatically triggers a build and tests to ensure the new functionality works as expected.
For example: after pushing changes, the system runs tests to check if a login form is functioning properly.

CI / CD Process Table:
Principle                   Description	                                                    Example
Single Source Repository	All files needed for the build are in a single repository.	    Git repo with code, database, and scripts.
Frequent                    Iterations	Small changes are pushed to the main branch often.	Frequent commits to the main branch.
Small Segments of Code	    Work in small code segments that are regularly integrated.	    Add small functionalities step-by-step.
Automated Builds and Tests	Use CI/CD tools to automate builds and tests.	                Jenkins or GitLab triggers tests after each commit.