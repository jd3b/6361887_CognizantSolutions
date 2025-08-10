# Git Basics + Notepad++ Integration + Add file to repo

## Commands to Execute in Git Bash:
- `git config --global user.name "Your Name"`
- `git config --global user.email "you@example.com"`
- `git config --global core.editor "'notepad++.exe' -multiInst -nosession"`
- `git init GitDemo`
- `cd GitDemo`
- `echo "Welcome to GitDemo" > welcome.txt`
- `git status`
- `git add welcome.txt`
- `git commit -m "Add welcome.txt"`
- `git remote add origin <your-remote-repo-url>`
- `git push origin master`
