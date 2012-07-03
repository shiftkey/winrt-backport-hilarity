Back to the Future - WinRT.Backport
=======================

First off, here's a puppy with a warning:

![](https://github.com/shiftkey/winrt-backport-hilarity/raw/master/intro.jpg)

This could be nothing, or people might be interested in it.

I was skimming over some old Win8 posts today, and got to thinking "What other crazy things could I start up?"

So I tweeted something:

<blockquote class="twitter-tweet"><p>an experiment in crowd-sourcing - what problems would you like to see me tackle for WinRT dev? add your ideas here <a href="https://t.co/d0kwKJbf" title="https://github.com/shiftkey/winrt-blogsamples/blob/master/README.md">github.com/shiftkey/winrt…</a></p>&mdash; Brendan Forster (@shiftkey) <a href="https://twitter.com/shiftkey/status/220014393159712772" data-datetime="2012-07-03T04:41:33+00:00">July 3, 2012</a></blockquote>

And this reply came back:

<blockquote class="twitter-tweet" data-in-reply-to="220014393159712772"><p>@<a href="https://twitter.com/shiftkey">shiftkey</a> Port Windows.Foundation to Desktop CLR. And errrr, blog about it I guess.</p>&mdash; Paul Betts (@xpaulbettsx) <a href="https://twitter.com/xpaulbettsx/status/220025531087855616" data-datetime="2012-07-03T05:25:49+00:00">July 3, 2012</a></blockquote>
<script src="//platform.twitter.com/widgets.js" charset="utf-8"></script>

So I've taken Paul's suggestion and gone a bit further:

## Can we provide an WinRT-compatible API for traditional .NET libraries to work against?

### Goals

 - Provide an interface which is forward-compatible but works on their current platform (for some subset of the .NET ecosystem) 
 - Allow library authors to migrate existing code gradually
 - As WinRT favours interfaces for much of its core, testability of existing libraries should not be harmed
 
What sorts of libraries did you have in mind?

 - Libraries which depend on the filesystem
 - ? Libraries which depend on the network
 - Scenarios where Portable Class Libraries is not suitable (TODO: which?)
 - ????

What sorts of libraries are not suited to this approach?

 - Libraries which use reflection heavily
 - ????

### The Experiment

Hell, I'm not even sure if this is legal. But anyway, here's what I've done so far.

 1. Use ILSpy to output the class definitions inside Windows.winmd (yes, it works).
 2. Hidden a bunch of namespaces temporarily to focus on Windows.Foundations.* and Windows.Storage.*
 3. Cleanup the existing code so that it compiles (no implementations behind the scenes so plenty of warnings)
 4. Grab the latest build of NLog and add to source.
 5. Create a new class library targeting NETFX_CORE to test for compilation.
 6. Use FileTarget (for example) to pull in enough files to get the code to compile

So for this case there's these three classes missing (without modifying any code):

 - FileStream
 - StackTrace
 - System.Threading.Timer

Which leads to an interesting topic:

### Different Types of Workarounds

I've been experimenting with a number of .NET OSS projects over the past few months to see where their pain points are and its generally come down to these sorts of behaviours:

 - this code is real important, and I want to run it on a different platform without modifying source
 - this code is real ugly, and I'd love an option to keep supporting the existing code and clean it up
 - i know this code isn't going to be supported in the future, so I need a way to switch it off

And these are the sorts of strategies I've used:

 - extension methods (for example, reflection) with minimal changes in the source to allow the implementation to be swapped out. Aliases is another one (used very well in JSON.NET)
 - an adapter to map the existing implementation to a new interface (less friction, short-term fix) or expose the new interface with the existing implementation behind it (more friction, long-term fix).
 - conditional compilation (although partial classes may be an option if the code can be refactored to separate core and platform-specific code).

### What next?

 - Experiment with how we can apply different shims/strategies to migrate NLog with minimal interruption
 - Expand the code porting process to identify more things
 - Prove this is feasible

### You're mad!

Yes. I've got [evidence](https://github.com/shiftkey/cloaked-hipster/pull/1/files) from co-workers who agree with you. Your point?

### Ok, how can I help?

I'm looking for OSS projects you'd like to use in Metro Style apps but haven't been brought across.

Skip these types of libraries:

 - testing and mocking libraries (something I'm already looking at - with the help of others, requires a different approach altogether)
 - ORM/data access libraries (they're likely dependent on ADO.NET - which just isn't there. Unless you've got a bright idea on this of course).
 - anything UI-specific - I'm drawing the line here for now. Nothing personal.

And of course you can bug me on [Twitter](https://twitter.com/shiftkey) about any of the above.