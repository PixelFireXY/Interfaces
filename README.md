# Interfaces

Here you can find some examples for how to create interfaces and how to use it
 <br> <br>
<b/>SoccerPlayer.cs</b> <br>
This class has implemented <i>IAthlete</i> and <i>IComparable</i>, the fist one is just an implementation of the base interface IAthlete and the second one is for use the CompareTo method for allow us to compare objects easly.
 <br> <br>
<b/>ISwimmer.cs, ISkier.cs, ITennisPlayer.cs, IAthlete.cs</b> <br>
All of this interfaces contains all the properties that a specific athlete must have
 <br> <br>
<b/>IUniversalAthlete.cs</b> <br>
This interface implement all the four interfaces above to create an athlete that knows everything!
 <br> <br>
<b/>CompleteAthlete.cs</b> <br>
This is the actual class that use <i>IUniversalAthlete</i> to get all the properties of all the interfaces and implement it.
 <br> <br>
<b/>Program.cs</b> <br>
Finally, here you can find the class <i>CompleteAthlete</i> instantiated, and because there is implemented two interfaces with the same method name and different behaviour (Exult), base of what is the cast of the athlete instance, you can call one or another.
