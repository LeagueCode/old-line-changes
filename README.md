# ChangesOnOldLine

## Following information provided:
- I know there used to be an issue in MyClass.cs
- I know that this issue used to be in Line 14 when it was fixed 

## What I want to know: 
- When the issue in line 14 was fixed, what happend to this line?
- Is there a straightforward solution get these information with git commands? 
- This should be done automaticly for different files and changes

I tried listing all commits of the file with `git log MyClass.cs` compare them with
 `Git diff {hash1} {hash2} - MyClass.cs` and check whether there is a change in Line 14.
 But this procedure seems cumbersome to me and I hope for a better, straightforward solution.  
 
 Link to stackoverflow: https://stackoverflow.com/questions/55844797/show-changes-on-what-used-to-be-line
