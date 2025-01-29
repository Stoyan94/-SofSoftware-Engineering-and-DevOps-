
Какво е Pull Request в Git?
    Pull Request (PR) е механизъм в Git-базираните платформи (като GitHub, GitLab и Bitbucket), 
    който позволява на разработчиците да предложат промени в основното (main) хранилище. 
    Това е начин да уведомите другите членове на екипа, че сте готови с определени промени и искате те да бъдат 
    прегледани, обсъдени и евентуално обединени (merged) в основния код.

    Как работи Pull Request?

    Създаване на клон (branch) – разработчикът създава нов клон и прави промени по кода.
    Качване в хранилището – след като приключи с промените, качва (push) този клон в отдалеченото хранилище.
    Създаване на Pull Request – подава заявка (PR), с която моли собствениците на проекта или други разработчици да прегледат и одобрят промените.
    Код ревю и коментари – останалите разработчици могат да прегледат кода, да дават обратна връзка и да поискат корекции.
    Сливане (Merge) – след одобрение, промените се обединяват в основния (main) клон.
    
    Примерни Git команди за Pull Request:

    git checkout -b feature-branch  # Създаване на нов клон
    git add .                       # Добавяне на промените
    git commit -m "Добавена нова функционалност"
    git push origin feature-branch  # Качване на новия клон в отдалеченото хранилище

    След това се създава Pull Request в Git платформата (GitHub, GitLab, Bitbucket и др.)


    git push -u origin feature-branch, което задава проследяващата връзка между локалния и отдалечения клон,
    така че при следващи git push команди няма да е нужно да указваш ръчно origin feature-branch.

    Когато за първи път качваш нов клон в отдалеченото хранилище, добра практика е да използваш git push -u (или --set-upstream). 
    Това задава проследяващ клон (upstream branch), което означава, че при бъдещи git push и git pull команди Git автоматично ще знае към кой клон да праща или получава промените.

        Примерен процес с git push -u:

    git checkout -b feature-branch  # Създаване на нов клон
    git add .                       # Добавяне на промените
    git commit -m "Добавена нова функционалност"
    git push -u origin feature-branch  # Качване и настройване на проследяващ клон

    След това можеш просто да използваш git push за следващи промени, без да е необходимо да указваш клона.

    /////////////////////////////////////////////////

    ENG
 What is a Pull Request in Git?

    A Pull Request (PR) is a feature in Git-based platforms (such as GitHub, GitLab, and Bitbucket) that allows developers to propose changes to a repository. 
    It is a way to notify team members that you have completed certain changes and want them to be reviewed, discussed, and possibly merged into the main codebase.

   How does a Pull Request work?
   Create a branch – The developer creates a new branch and makes changes to the code.
   Push to the repository – After finishing the changes, they push the branch to the remote repository.
   Open a Pull Request – They submit a PR, asking project maintainers or other developers to review and approve the changes.
   Code review and feedback – Other developers review the code, provide feedback, and request modifications if needed.
   Merge the changes – Once approved, the changes are merged into the main branch.

   Example Git commands for a Pull Request:

    git checkout -b feature-branch  # Create a new branch
    git add .                       # Stage changes
    git commit -m "Added new feature"
    git push origin feature-branch  # Push the branch to the remote repository

   Then, a Pull Request is created on the Git platform (GitHub, GitLab, Bitbucket, etc.)


    In English:
    When pushing a new branch to the remote repository for the first time, it’s a good practice to use git push -u (or --set-upstream). 
    This sets up an upstream tracking branch, meaning that for future git push and git pull commands, Git will automatically know which branch to push to or pull from.

        Example process with git push -u:
    
    git checkout -b feature-branch  # Create a new branch
    git add .                       # Stage changes
    git commit -m "Added new feature"
    git push -u origin feature-branch  # Push and set upstream tracking branch
    After this, you can simply use git push for future updates without specifying the branch name.
