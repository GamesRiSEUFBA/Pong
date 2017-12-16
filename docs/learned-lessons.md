# Learned lessons
## Background

This Pong project was made with 2 main objectives in mind: **1)** to learn how to develop games using Unity and **2)** how to collaborate as a team and integrate Unity with Git.

Before we started, each one of us made our own implementation of Pong using Unity. Each person could use any tutorials and assets they liked. After everyone finished their own Pong, we started planning to work on this one, with more features and collaboration in mind.

The background in our team was diverse:
* Not everyone had previous experience developing games
* Not everyone was familiarized with Git and version control, or the person was used to a different tool for source code versioning (such as SVN).
* Some were already graduated in an IT-related course, others are still in the beginning of their IS/CS course

## What we learned
We got valuable experience from working as team. Most of the efforts within this project lied in using Git together with Unity and seeing how the files behaved when different people were working on them. Here, we're putting a list of lessons we felt were important to share:

### An Unity project folder doesn't look like your typical source code
When developing a typical software project, you use version control to manage the source code. However, most of an Unity project 'source code' is actually very hard to read or edit outside the IDE. This makes is harder to look into what exactly a commit changed - you can't easily read the diffs on Github or your favorite/personal Git host. Because of that, we had to make sure our commits had useful descriptions.

### There is very little documentation online about using Unity together with Git
Before we started working with source code, each of us looked into how to properly integrate both tools for game development. We learned that there isn't much information about that online aside from very basic topics (such as setting up a Git repo).

### Collaboration is easier when everyone is working on a different part of the project
We had very little success when trying to edit the same scene in Unity. It seems Git has trouble merging scene files. On the other side, everything went more smoothly when each person was working on a different scene. This might indicate that collaboration works better when you have different people working on different levels, for example. However, for a project like Pong, it may be better to have a main programmer and leave the rest with documentation and asset management.
