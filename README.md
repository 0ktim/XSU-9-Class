# <img src="https://media.tenor.com/gtImyJ4ruGgAAAAi/logo-bulgaria.gif" height="100">   СУ "Йордан Йовков" - Сливен

## :man_technologist: Професия: "Приложен програмист" - :mortar_board: 9а клас

## Проектът "XSU-9-Clаss" е уеб репозитори, който цели да подпомогне обучението на учениците чрез интерактивни уроци, задачи и ресурси.

# Инсталация

## 1. Инструкции за клониране на репозитори към вашия локален Git:

<img src="https://i.ibb.co/nzgXRQ1/git-clone.png">

<br>

**Клониране на репозиторито:** 

<br>

За да започнете работа с проекта, клонирайте това репозитори към вашия локален Git, използвайки една от следните команди в терминала:

  - Клониране на репозиторито и извличане на всички клонове.

    ```
    git clone https://github.com/0ktim/XSU-9-Class.git
    ```
  - Клониране на репозиторито и извличане на всички клонове, като незабавно достъпвате до конкретен клон.

    ```
    git clone --branch ИМЕ-НА-КЛОНА https://github.com/0ktim/XSU-9-Class.git
    ```

  - Клониране на репозиторито и извличане само на един клон.

    ```
    git clone --branch ИМЕ-НА-КЛОНА --single-branch https://github.com/0ktim/XSU-9-Class.git
    ```
<br>
<br>

## 2. Инструкции за пушване на промени в GitHub репозитори:


<img src="https://i.ibb.co/RyPzYKs/git-push.png">

<br>

**Пушване на репозиторито:** 

<br>

  1. **Проверка на състоянието на файловете:**
     - Преди да добавите, фиксирайте и пушнете промените, може да е полезно да проверите състоянието на вашите файлове в репозиторията с командата "git status". Тази команда ще покаже наличните промени във вашето репозитори, както и информация за това кой файл е добавен, променен или изтрит.

        ```
        git status
        ```

  1. **Добавяне на промените:**
     - Преди да пушнете промените, трябва да ги добавите към индекса на Git. Това се прави с командата "git add .", където "." добавя всички промени.

        ```
        git add .
        ```
        
  1. **Фиксиране на промените:**
     - След добавянето на промените към индекса, трябва да ги фиксирате с команда " git commit -m "Съобщение за комита" ". Заменете "Съобщение за комита" със съобщението, което описва промените, които правите.

        ```
        git commit -m "Съобщение за комита"
        ```

  1. **Пушване на промените:**
     - След като сте фиксирали промените, може да ги пушнете в GitHub репозиторито с командата "git push".

        ```
        git push
        ```
        




## Принципна схема на Дистрибутирана Система за Контрол на Версията. 

Всеки сътрудник има локално копие на репозиторито.

<img src="https://miro.medium.com/v2/resize:fit:1400/format:webp/1*ylXqYPTqezonRkywhOa6cg.png" width="100%">

