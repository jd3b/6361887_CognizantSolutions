# Merge Conflict Resolution

## Commands to Execute in Git Bash:
- `cd GitDemo`
- `git checkout -b GitWork`
- `echo "Branch hello" > hello.xml`
- `git add hello.xml`
- `git commit -m "Add hello.xml in branch"`
- `git checkout master`
- `echo "Master hello" > hello.xml`
- `git add hello.xml`
- `git commit -m "Add hello.xml in master"`
- `git merge GitWork`
- `# Resolve conflict in editor`
- `git add hello.xml`
- `git commit -m "Resolve merge conflict"`
- `git branch -d GitWork`
