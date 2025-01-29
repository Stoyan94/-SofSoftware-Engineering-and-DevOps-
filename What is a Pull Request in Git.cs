
����� � Pull Request � Git?
    Pull Request (PR) � ��������� � Git-���������� ��������� (���� GitHub, GitLab � Bitbucket), 
    ����� ��������� �� �������������� �� ��������� ������� � ��������� (main) ���������. 
    ���� � ����� �� ��������� ������� ������� �� �����, �� ��� ������ � ���������� ������� � ������ �� �� ����� 
    ����������, �������� � ���������� ��������� (merged) � �������� ���.

    ��� ������ Pull Request?

    ��������� �� ���� (branch) � ������������� ������� ��� ���� � ����� ������� �� ����.
    ������� � ����������� � ���� ���� �������� � ���������, ����� (push) ���� ���� � ������������ ���������.
    ��������� �� Pull Request � ������ ������ (PR), � ����� ���� ������������� �� ������� ��� ����� ������������ �� ��������� � ������� ���������.
    ��� ���� � ��������� � ���������� ������������ ����� �� ��������� ����, �� ����� ������� ������ � �� ������� ��������.
    ������� (Merge) � ���� ���������, ��������� �� ���������� � �������� (main) ����.
    
    �������� Git ������� �� Pull Request:

    git checkout -b feature-branch  # ��������� �� ��� ����
    git add .                       # �������� �� ���������
    git commit -m "�������� ���� ��������������"
    git push origin feature-branch  # ������� �� ����� ���� � ������������ ���������

    ���� ���� �� ������� Pull Request � Git ����������� (GitHub, GitLab, Bitbucket � ��.)


    git push -u origin feature-branch, ����� ������ �������������� ������ ����� �������� � ����������� ����,
    ���� �� ��� �������� git push ������� ���� �� � ����� �� ������� ����� origin feature-branch.

    ������ �� ����� ��� ������ ��� ���� � ������������ ���������, ����� �������� � �� ��������� git push -u (��� --set-upstream). 
    ���� ������ ����������� ���� (upstream branch), ����� ��������, �� ��� ������ git push � git pull ������� Git ����������� �� ���� ��� ��� ���� �� ����� ��� �������� ���������.

        �������� ������ � git push -u:

    git checkout -b feature-branch  # ��������� �� ��� ����
    git add .                       # �������� �� ���������
    git commit -m "�������� ���� ��������������"
    git push -u origin feature-branch  # ������� � ����������� �� ����������� ����

    ���� ���� ����� ������ �� ��������� git push �� �������� �������, ��� �� � ���������� �� ������� �����.

    /////////////////////////////////////////////////

    ENG
 What is a Pull Request in Git?

    A Pull Request (PR) is a feature in Git-based platforms (such as GitHub, GitLab, and Bitbucket) that allows developers to propose changes to a repository. 
    It is a way to notify team members that you have completed certain changes and want them to be reviewed, discussed, and possibly merged into the main codebase.

   How does a Pull Request work?
   Create a branch � The developer creates a new branch and makes changes to the code.
   Push to the repository � After finishing the changes, they push the branch to the remote repository.
   Open a Pull Request � They submit a PR, asking project maintainers or other developers to review and approve the changes.
   Code review and feedback � Other developers review the code, provide feedback, and request modifications if needed.
   Merge the changes � Once approved, the changes are merged into the main branch.

   Example Git commands for a Pull Request:

    git checkout -b feature-branch  # Create a new branch
    git add .                       # Stage changes
    git commit -m "Added new feature"
    git push origin feature-branch  # Push the branch to the remote repository

   Then, a Pull Request is created on the Git platform (GitHub, GitLab, Bitbucket, etc.)


    In English:
    When pushing a new branch to the remote repository for the first time, it�s a good practice to use git push -u (or --set-upstream). 
    This sets up an upstream tracking branch, meaning that for future git push and git pull commands, Git will automatically know which branch to push to or pull from.

        Example process with git push -u:
    
    git checkout -b feature-branch  # Create a new branch
    git add .                       # Stage changes
    git commit -m "Added new feature"
    git push -u origin feature-branch  # Push and set upstream tracking branch
    After this, you can simply use git push for future updates without specifying the branch name.
