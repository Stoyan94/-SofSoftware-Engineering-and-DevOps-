Българска версия:
Какво е YAML?
1. Въведение
YAML (Yet Another Markup Language) или YAML Ain’t Markup Language е текстов формат за сериализация на данни, който е лесен за четене и писане от хора. 
Използва се широко в конфигурационни файлове, CI/CD (като GitHub Actions), Kubernetes и други инструменти.

✅ Предимства на YAML:

Четимост – по-лесен за разбиране от JSON и XML
Минимализъм – няма излишни скоби {} или кавички ""
Поддържа вложени структури – лесен за организиране на данни
Съвместимост – може да бъде конвертиран в JSON

2. Основен синтаксис
2.1 Ключ-стойност двойки
Форматът на YAML се базира на ключ-стойност двойки, разделени с :

yaml
име: Иван
възраст: 30
град: София

➡️ JSON еквивалент:
json
{
  "име": "Иван",
  "възраст": 30,
  "град": "София"
}


2.2 Вложени структури(Indentation / Отстъпи)
YAML използва интервали (спейсове) вместо скоби, за да показва вложени структури. 
Не се използват табулации!

yaml
човек:
  име: Иван
  възраст: 30
  адрес:
град: София
държава: България

➡️ JSON еквивалент:
json
{
  "човек": {
    "име": "Иван",
    "възраст": 30,
    "адрес": {
        "град": "София",
      "държава": "България"
    }
}
}


2.3 Списъци(Arrays)
Списъците в YAML се обозначават с - в началото на всеки елемент.

yaml
езици:
  -Python
  - JavaScript
  - C#

➡️ JSON еквивалент:
json
{
  "езици": ["Python", "JavaScript", "C#"]
}


2.4 Списъци с обекти
Можем да комбинираме списъци и обекти, за да съхраняваме по-сложни данни.

yaml
хора:
  -име: Иван
    възраст: 30
  - име: Мария
    възраст: 25

➡️ JSON еквивалент:
json
{
  "хора": [
    { "име": "Иван", "възраст": 30 },
    { "име": "Мария", "възраст": 25 }
  ]
}


2.5 Коментари
В YAML можем да използваме #, за да добавяме коментари.

yaml
име: Иван  # Това е име на човек
възраст: 30  # Това е възраст


3.Разширени YAML функционалности
3.1 Специални типове данни
YAML поддържа различни типове стойности, включително bool (true/false), null, числа, низове и дати.

yaml
активен: true
стойност: null
години_опит: 5
дата_на_раждане: 1993 - 07 - 23

➡️ JSON еквивалент:
json
{
  "активен": true,
  "стойност": null,
  "години_опит": 5,
  "дата_на_раждане": "1993-07-23"
}


3.2 Многоредови стойности
Ако трябва да записваме голям текст, YAML предоставя два начина:

| (Pipe) – запазва всички нови редове
> (Greater-than) – премахва новите редове и ги комбинира в един ред

yaml
описание: |
  Това е примерен многоредов текст.
  Той запазва всички нови редове.

бележка: >
  Това е друг многоредов текст,
  но новите редове ще се съединят
  в един дълъг ред.

➡️ JSON еквивалент:

json
{
  "описание": "Това е примерен многоредов текст.\nТой запазва всички нови редове.\n",
  "бележка": "Това е друг многоредов текст, но новите редове ще се съединят в един дълъг ред."
}


4.YAML в GitHub Actions
В GitHub Actions YAML се използва за конфигуриране на автоматизирани процеси (workflows).

yaml
name: CI Pipeline

on: push  # Изпълнява се при push

jobs:
  build:
runs - on: ubuntu - latest
    steps:
-name: Checkout код
        uses: actions / checkout@v3
      - name: Компилиране на кода
        run: echo "Компилиране..."

Заключение
✅ YAML е лесен за четене и удобен за конфигурационни файлове.
✅ Работи в CI/CD, Kubernetes, Ansible и други инструменти.
✅ Няма излишни скоби, но изисква внимателно спазване на отстъпите (интервалите).






English version:

What is YAML ?
1.Introduction
YAML(Yet Another Markup Language) or YAML Ain’t Markup Language is a data serialization format that is easy for humans to read and write. 
It is widely used for configuration files, CI/CD pipelines (such as GitHub Actions), Kubernetes, and other tools.

✅ Advantages of YAML:

Readability – easier to understand than JSON and XML
Minimalist syntax – no unnecessary {} or ""
Supports nested structures – easy to organize data
Compatibility – can be converted to JSON

2. Basic Syntax
2.1 Key-Value Pairs
YAML is based on key-value pairs, separated by :

yaml
name: John
age: 30
city: New York

➡️ JSON equivalent:
json
Copy
Edit
{
  "name": "John",
  "age": 30,
  "city": "New York"
}


2.2 Nested Structures(Indentation)
YAML uses spaces instead of brackets to define nested structures. 
Tabs are not allowed!

yaml
person:
  name: John
  age: 30
  address:
city: New York
    country: USA

➡️ JSON equivalent:
json
Copy
Edit
{
  "person": {
    "name": "John",
    "age": 30,
    "address": {
        "city": "New York",
      "country": "USA"
    }
}


2.3 Lists(Arrays)
Lists in YAML use - to define elements.

yaml
languages:
  -Python
  - JavaScript
  - C#

➡️ JSON equivalent:
json
{
  "languages": ["Python", "JavaScript", "C#"]
}


2.4 Lists of Objects
You can combine lists and objects to store complex data.

yaml
people:
  -name: John
    age: 30
  - name: Mary
    age: 25
    
➡️ JSON equivalent:
json
{
  "people": [
    { "name": "John", "age": 30 },
    { "name": "Mary", "age": 25 }
  ]
}


2.5 Comments
In YAML, comments are written using #.

yaml
name: John  # This is a person's name
age: 30  # This is the age


3.Advanced YAML Features
3.1 Special Data Types
YAML supports various data types, including boolean, null, numbers, strings, and dates.

yaml
active: true
value: null
years_experience: 5
birth_date: 1993 - 07 - 23


➡️ JSON equivalent:
json
{
  "active": true,
  "value": null,
  "years_experience": 5,
  "birth_date": "1993-07-23"
}


3.2 Multi - line Strings
For large text blocks, YAML provides two options:

| (Pipe) – preserves all new lines
> (Greater - than) – removes new lines and joins them into one

yaml
description: |
  This is an example of a multi-line string.
  It preserves all line breaks.

note: >
  This is another multi - line string,
  but the new lines will be merged
  into a single long line.

➡️ JSON equivalent:
json
{
  "description": "This is an example of a multi-line string.\nIt preserves all line breaks.\n",
  "note": "This is another multi-line string, but the new lines will be merged into a single long line."
}


4.YAML in GitHub Actions
In GitHub Actions, YAML is used to define automated processes (workflows).

yaml
name: CI Pipeline

on: push  # Runs on a push event

jobs:
  build:
runs - on: ubuntu - latest
    steps:
-name: Checkout code
        uses: actions / checkout@v3
      - name: Build the code
        run: echo "Building..."


Conclusion
✅ YAML is human-readable and ideal for configuration files.
✅ It is widely used in CI/CD, Kubernetes, Ansible, and other automation tools.
✅ No brackets needed, but indentation (spaces) must be carefully maintained.