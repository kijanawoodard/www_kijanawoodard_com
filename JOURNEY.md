# The Journey

## 2021-09-30 
Finally! Made the first commit for my new blog engine.

This has been rattling around in my head for a while.

Before I get down into the details, I'll establish a little bit of structure. Makefile, tests, and get it running on netlify. Then I can build and push and iterate and have "something to show" all the time.

I'm going to attempt to follow trunk based development and write tests.

Welp! There's a snag. Was humming along and found out that netlify doesn't support dotnet core.

They maintain a "build image" and `dotnet` isn't on the supoprted list: https://github.com/netlify/build-image/blob/focal/included_software.md

It's been asked for, but no dice yet: https://answers.netlify.com/t/netlify-support-for-dotnet-core/21463

They don't seem to get that "dotnet" isn't "just webapps".

That's all well in good, but the build doesn't exactly "break" when you try to run a .net app. It just runs forever doing gcc tasks.

I sent them a support email:
<pre lang="txt">
Hello,

I started working on my own static site engine with dotnet 6.
I've used netlify for years and love it.

I didn't even _think_ about whether netlify "supported" dotnet. I figured it would just be there.

At any rate, I can see in the image repo that dotnet is not listed.

However, the build does....something.
I cancelled it after a while, but it looks like the process will just keep going.

You should probably find a way to kill this faster...
Or better yet, add dotnet to the list of supported languages/frameworks. ;-)

Here's a link to the build I cancelled:
https://app.netlify.com/sites/eager-gates-de1896/deploys/6155b0288dbe4e00083c30b0

Fwiw, my plan was to use `make run` to output to `src/site` and have index.html et al in there for netlify. That way, no matter how I triggered a deployment, everything would get built. For now, my plan is to remove src/site from .gitignore and not have a build on netlify at all.

Thank you,
Kijana Woodard
</pre>
