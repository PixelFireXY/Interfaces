# Interfaces

Here you can find some examples for how to create interfaces and how to use it

<b/>SoccerPlayer.cs</b>
This class has implemented IAthlete and IComparable, the fist one is just an implementation of the base interface IAthlete and the second one is for use the CompareTo method for allow us to compare objects easly.

<b/>ISwimmer.cs, ISkier.cs, ITennisPlayer.cs, IAthlete.cs</b>
All of this interfaces contains all the properties that a specific athlete must have

<b/>IUniversalAthlete.cs</b>
This interface implement all the four interfaces above to create an athlete that knows everything!

<b/>CompleteAthlete.cs</b>
This is the actual class that use IUniversalAthlete to get all the properties of all the interfaces and implement it.

<b/>Program.cs</b>
Finally, here you can find the class CompleteAthlete instantiated, and because there is implemented two interfaces with the same method name and different behaviour (Exult), base of what is the cast of the athlete instance, you can call one or another.
