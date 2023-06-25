1. git remote -v

- проверяет все пути к удаленному репозиторию
2. git remote add _origin_ <и ссылка на репозиторий>

- добавляет ссылку на удаленный репозиторий с коротким именем (путем) _origin_

3. git push -u _origin_ main

- отправляет изменения в ветку main удаленного репозитория, который озоглавлен как _origin_

4. git fetch --all 

- проверяет изменения, которые есть в удаленном репозитории

5. git log _origin_/main ^main 

- сравнивает ветку main в удаленном репозитории и в локальном (после значка ^)

6. git merge origin/main 

- сливает изменения из удаленного репозитория в локальный

7. git log --graph --pretty=format: '%Cred%h%Creset -%C(yellow)%d%Creset %s %Cgreen(%cr) %C(bold blue)<%an>%Creset' --abbrev-commit 

- не работает

8. git checkout -b <имя ветки> - создание новой ветки

9. git blame <file.name> - показывает все коммиты для каждой строчки

10. git revert <hash> - reverts commit with a hash <>

11. git diff <from hash> <to hash> - to see the difference from one commit to the other.

12. git remote show origin - очень похоже на git remote -v , но в данном случае показывает все связи между локальным и удаленным репозиториями.

13. git rm --cached <file.name> <file.name> - удаляет из индекса файлы

14. git remote set-url --push origin <new-path> - новый удаленный репозиторий для имени origin для команды push

15. git merge origin/master - сливает изменения, которые были затянуты командой fetch из удаленного репозитория origin и ветки master

16. Для того, чтобы отправлять изменения сразу в несколько репозиториев, надо:

16.1 задать удаленный репозиторий командой: git remote add all path-1

16.2 добавить к этому репозиторию дополнительные пути:
git remote set-url --add --push all path-1
git remote set-url --add --push all path-2

16.3 отправлять наши изменения сразу во все репозитории, используя имя all:
git push all main

17. git restore index.html - возвращает файл к исходному состоянию (до изменений)

18. git restore --staged styles.css - возвращаем файл из индекса

19. git checkout b45a983 index.html - возвращает конкретный файл к состоянию заданного коммита

20. git revert --no-commit hash3
    git revert --no-commit hash2
    git revert --no-commit hash1 - последовательная отмена коммита без сохранения изменений в новом коммите

21. git reset --soft <hash> - сбросить коммит, то, что раньше было в коммите, отправится в индекс.

22. git reset --mixed <hash> - сбрасываем коммит, изменения будут в статусе modified. Это вариант по умолчанию для git reset.

23. git reset --hard <hash> - безвозвратное удаление коммитов до hash.

24. git commit --amend -m 'new comment' - запись нового комментария в последний коммит

25. Если необходимо добавить файл в последний коммит, то надо сделать:

25.1 git add .

25.2. и добавить в последний коммит аналогичной командой:
git commit --amend --no-edit

26. git reset --merge hash - отмена слияния веток.

27. Если слияние не произошло из-за конфликтов, то его можно отметить другой командой:

git merge --abort

28. git stash - откладывание изменений

29. git stash pop - возврат ранее отложенных изменений

30. git stash drop - отмена отложенных изменений

31. git rebase dev - перенос ветки dev в текущую ветку с сохранением всех коммитов ветки dev.

32. git merge dev - слияние ветки dev с текущей, при этом вся история коммитов ветки dev пропадает.

33. git cherry-pick <d> - перенос в текущую ветку конкретного коммита из другой ветки

34. 