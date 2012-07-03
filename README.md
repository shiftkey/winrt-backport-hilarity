WinRT.Backport
=======================

First off, here's a puppy with a warning:

![](https://github.com/shiftkey/winrt-backport-hilarity/raw/master/intro.jpg)

This could be nothing, or people might be interested in it.

I was skimming over some old Win8 posts today, and got to thinking "What other crazy things could I start up?"

<blockquote class="twitter-tweet"><p>an experiment in crowd-sourcing - what problems would you like to see me tackle for WinRT dev? add your ideas here <a href="https://t.co/d0kwKJbf" title="https://github.com/shiftkey/winrt-blogsamples/blob/master/README.md">github.com/shiftkey/winrt…</a></p>&mdash; Brendan Forster (@shiftkey) <a href="https://twitter.com/shiftkey/status/220014393159712772" data-datetime="2012-07-03T04:41:33+00:00">July 3, 2012</a></blockquote>

And this reply came back:

<blockquote class="twitter-tweet" data-in-reply-to="220014393159712772"><p>@<a href="https://twitter.com/shiftkey">shiftkey</a> Port Windows.Foundation to Desktop CLR. And errrr, blog about it I guess.</p>&mdash; Paul Betts (@xpaulbettsx) <a href="https://twitter.com/xpaulbettsx/status/220025531087855616" data-datetime="2012-07-03T05:25:49+00:00">July 3, 2012</a></blockquote>
<script src="//platform.twitter.com/widgets.js" charset="utf-8"></script>

So I've taken Paul's suggestion and gone a bit further:

 - Can we provide an WinRT-compatible library  for traditional .NET libraries to work against?

Why?

 - Provide an interface which is forward-compatible but works on their current platform (for some subset of the .NET ecosystem) 
 - Source-friendly way to test existing code
 - Allow library authors to migrate existing code gradually
 - For scenarios where Portable Class Libraries is not suitable (TODO: discuss)

What sorts of things are good candidates?

 - Libraries which depend on the filesystem
 - ? Libraries which depend on the network
 - ????

Hell, I'm not even sure if this is legal. But anyway, here's what I've done so far.

 1. Use ILSpy to output the class definition inside Windows.winmd (yes, it works).
 2. Turned off a bunch of namespaces for now to focus on Windows.Foundations.* and Windows.Storage.*
 3. Cleanup the existing code so that it compiles (without implementations behind the scenes)
 4. Grab the latest build of NLog and add to source
 5. Create a new class library targeting NETFX_CORE to test for compilation
 6. Use FileTarget (for example) to pull in enough files to get the code to compile

So for this case there's these three classes missing (without modifying any code):

 - FileStream
 - StackTrace
 - System.Threading.Timer

I'm focusing on the first one for now (not sure if the second one is supported, the third is an interesting case for a different polyfill).


