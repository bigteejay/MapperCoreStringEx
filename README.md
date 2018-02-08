# Bug Reproduction for AutoMapper >= v6.1.0

I discovered what appears to be a bug that exists in versions of AutoMapper **after** v6.02 (confirmed with v6.1.0 and later).

If `lines 22-23` in the `RegistrationData.cs` file are commented out (any version of AutoMapper), then the included code will run without issue.

If those lines are **not** commented out, with v4.2.0 (original version I had when this was working) through v6.0.2, it will run without issue.

Starting at version v6.1.0 and on, when `Map()` is called (`line 29` in `Program.cs`), an exception is thrown...

**System.FormatException:** 'Input string was not in a correct format.'

This error isn't too terribly helpful (would be nice to know which field this relates to, I had to try each to narrow it down.)

Is this an issue in my code (some breaking change between those two that would explain this and I didn't account for?)


