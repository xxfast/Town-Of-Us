
[![Discord](https://discord.com/assets/e4923594e694a21542a489471ecffa50.svg)](https://discord.gg/bYSaT74KzT)

# ![Logo](./Images/logo.png)

![Everyone](./Images/Everything.png)
An Among Us mod that adds a bunch of roles, modifiers and game settings




**Crewmate Roles**
- [Mayor](#mayor)
- [Lovers](#lovers)
- [Sheriff](#sheriff)
- [Engineer](#engineer)
- [Swapper](#swapper)
- [Investigator](#investigator)
- [Time Lord](#time-lord)
- [Medic](#medic)
- [Seer](#seer)
- [Child](#child)
- [Spy](#spy)
- [Snitch](#snitch)

**Neutral Roles**
- [Jester](#jester)
- [Shifter](#shifter)
- [The Glitch](#the-glitch)
- [Executioner](#executioner)
- [Arsonist](#arsonist)

**Impostor Roles**
- [Janitor](#janitor)
- [Morphling](#morphling)
- [Camouflager](#camouflager)
- [Miner](#miner)
- [Swooper](#swooper)

**Modifiers**
- [Torch](#torch)
- [Diseased](#diseased)
- [Flash](#flash)
- [Tiebreaker](#tiebreaker)
- [Drunk](#drunk)



# Releases :
| Among Us - Version| Mod Version | Link |
|----------|-------------|-----------------|
| 2021.3.5s | v1.2.0 | [Download](https://github.com/slushiegoose/Town-Of-Us/releases/download/v1.2.0/TownOfUs-v1.2.0.zip) |
| 2021.3.5s | v1.1.0 | [Download](https://github.com/slushiegoose/Town-Of-Us/releases/download/v1.1.0/TownOfUs-v1.1.0-2021.3.5s.zip) |
| 2020.12.19s | v1.1.0 | [Download](https://github.com/slushiegoose/Town-Of-Us/releases/download/v1.1.0/TownOfUs-v1.1.0-2020.12.9s.zip) |
| 2020.12.19s | v1.0.3 | [Download](https://github.com/slushiegoose/Town-Of-Us/releases/download/v1.0.3/TownOfUs-v1.0.3.zip) |
| 2020.12.19s | v1.0.2 | [Download](https://github.com/slushiegoose/Town-Of-Us/releases/download/v1.0.2/TownOfUs-v1.0.2.zip) |
| 2020.12.19s | v1.0.1 | [Download](https://github.com/slushiegoose/Town-Of-Us/releases/download/v1.0.1/TownOfUs-v1.0.1.zip) |
| 2020.12.19s | v1.0.0 | [Download](https://github.com/slushiegoose/Town-Of-Us/releases/download/v1.0.0/TownOfUs-v1.0.0.zip) |

<details>
  <summary> Changelog </summary>

  
 <details>
  <summary> v1.2.0 </summary>
  <ul>
    <li> New roles (see above)</a>
    <li> New modifiers (see above)</li>
    <li> Exporting and Importing game settings which sync between versions 1.2.0 and future versions</li>
    <li> Disconnect fix </li>
    <li> Mayor additions - Abstain button, Option for Mayor's extra votes to be anonymous </li>
    <li> Option for dead to see the roles of everyone </li>
    <li> Custom colours now work! </li>
  </ul>
  </details>
  <details>
  <summary> v1.1.0 </summary>
  <ul>
    <li> New roles (see above)</a>
    <li> New modifiers (see above)</li>
    <li> The Engineer has been changed to the <a href="https://github.com/NotHunter101/ExtraRolesAmongUs">ExtraRoles</a> version </li>
    <li> Backend overhaul! This will make it easier to add new roles </li>
    <li> New Button Art! </li>
    <li> Maps and Impostor Count can be changed from the Lobby! </li>
    <li> Shadows for the Custom Colours </li>
    <li> Fixes </li>
    <ul>
      <li> The Jester and The Shifter unable to fix Sabotages </li>
      <li> The Time Lord's Rewind not auto-force closing tasks </li>
      <li> The Q button not working for Sheriff </li>
      <li> The Shifter's Shift looking too much like a Kill </li>
      <li> Changing colours would render you weirdly green in normal Among Us </li>
    </ul>
  </ul>
  </details>


  <details>
  <summary> v1.0.3 </summary>
  <p> Fixes: </p>
  <ul>
    <li> Engineer being able to Fix every sabotage </li>
    <li> The Investigator being able to revive people voted out (and instead made it an option) </li>
    <li> Footprints not appearing if a person walks over old footprints </li>
    <li> Graphical glitch where Jester and Lovers simultaneously win </li>
    <li> Players spawning back into positions from the last game when time is rewound right at the beginning of a new game </li>
    <li> Graphical Bug of Time Lord's name not being blue in Meetings </li>
    <li> Fixed Medbay Scan not working for custom colours </li>
  </ul>
  </details>

  <details>
  <summary> v1.0.2 </summary>
  <p> Fixes: </p>
  <ul>
    <li>  The Swapper being unable to vote </li>
    Swapper unable to vote
    <li> Mayor Vote Bank ending up negative </li>
    <li> Anonymous Voting not working when Mayor is in a game </li>
    <li> Chats not working in the lobby </li>
    <li> Sheriff desync (I think) </li>
    <li> Buttons being able to be used during meetings </li>
  </ul>
  <hr>
  </details>

  <details>
  <summary> v1.0.1 </summary>
  <p> Fixes errors of not being able to launch. </p>
  </details>
</details>


# Installation
**Download the zip file on the right side of Github.**  
1. Find the folder of your game, for steams players you can right click in steam, on the game, a menu will appear proposing you to go to the folders.
2. Make a copy of your game (not required but recommended)
3. Drag or extract the files from the zip into your game, at the .exe level.
4. Turn on the game.
5. Play the game.

![Install](https://i.imgur.com/pvBAyZN.png)

# Roles
# Crewmate Roles
## Mayor
### **Team: Crewmates**
The Mayor is a Crewmate that can vote multiple times.\
The Mayor has a Vote Bank, which is the number of times they can vote.\
They have the option to abstain their vote during a meeting, adding that vote to the Vote Bank.\
As long as not everyone has voted, the Mayor can use as many votes from their Vote Bank as they please.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Mayor | The percentage probability of the Mayor appearing | Percentage | 0% |
| Initial Mayor Vote Bank | The number of votes in the Vote Bank at the start of a game | Number | 1 |
| Mayor Votes Show Anonymous | Whether the Mayor's extra votes will show up anonymously | Toggle | False |

-----------------------
## Lovers
### **Team: Crewmates or Impostors**
The Lovers are two players who are linked together.\
These two players get picked randomly between Crewmates and Impostors.\
They gain the primary objective to stay alive together.\
If they are both among the last 3 players, they win.\
In order to so, they gain access to a private chat, only visible by them in between meetings.\
However, they can also win with their respective team, hence why the Lovers do not know the role of the other lover.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Lovers | The percentage probability of the Lovers appearing | Percentage | 0% |
| Both Lovers Die | Whether the other Lover automatically dies if the other does | Toggle | True |

-----------------------
## Sheriff
### **Team: Crewmates**
The Sheriff is a Crewmate that has the ability to eliminate the Impostors using their kill button.\
However, if they kill a Crewmate or a Neutral player they can't kill, they instead die themselves.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Sheriff | The percentage probability of the Sheriff appearing | Percentage | 0% |
| Show Sheriff | Whether everybody can see who the Sheriff is | Toggle | False |
| Sheriff Miskill Kills Crewmate | Whether the other player is killed if the Sheriff Misfires | Toggle | False |
| Sheriff Kills Jester | Whether the Sheriff is able to kill the Jester | Toggle | False |
| Sheriff Kills The Glitch | Whether the Sheriff is able to kill The Glitch | Toggle | False |
| Sheriff Kills Arsonist | Whether the Sheriff is able to kill the Arsonist | Toggle | False |
| Sheriff Kill Cooldown | The cooldown on the Sheriff's kill button | Time | 25s |

-----------------------
## Engineer
### **Team: Crewmates**
The Engineer is a Crewmate that can fix sabotages from anywhere on the map.\
They can use vents to get across the map easily.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Engineer | The percentage probability of the Engineer appearing | Percentage | 0% |
| Engineer Fix Per | Whether the Engineer can fix 1 sabotage per round or per game | Round / Game | Round |

-----------------------
## Swapper
### **Team: Crewmates**
The Swapper is a Crewmate that can swap the votes on 2 players during a meeting.\
All the votes for the first player will instead be counted towards the second player and vice versa.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Swapper | The percentage probability of the Swapper appearing | Percentage | 0% |

-----------------------
## Investigator
### **Team: Crewmates**
The Investigator is a Crewmate that can see the footprints of players.\
Every footprint disappears after a set amount of time.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Investigator | The percentage probability of the Investigator appearing | Percentage | 0% |
| Footprint Size | The size of the footprint on a scale of 1 to 10 | Number | 4 |
| Footprint Interval | The time interval between two footprints | Time | 1s |
| Footprint Duration | The amount of time that the footprint stays on the ground for | Time | 10s |
| Anonymous Footprint | When enabled, all footprints are grey instead of the player's colors | Toggle | False
| Footprint Vent Visible | Whether footprints near vents are shown | Toggle | False

-----------------------
## Time Lord
### **Team: Crewmates**
The Time Lord is a Crewmate that can rewind time and reverse the positions of all players.\
If enabled, any players killed during this time will be revived.\
Nothing but movements and kills are affected.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Time Lord | The percentage probability of the Time Lord appearing | Percentage | 0% |
| Revive During Rewind | Whether the Time Lord revives dead players when rewinding | Toggle | False |
| Rewind Duration | How far the rewind goes back in time | Time | 3s |
| Rewind Cooldown | The cooldown of the Time Lord's Rewind button | Time | 25s |
| Time Lord can use Vitals | Whether the Time Lord has the ability to use Vitals | Toggle | False |

-----------------------
## Medic
### **Team: Crewmates**
The Medic is a Crewmate that can give any player a shield that will make them immortal until the Medic dies.\
A Shielded player cannot be Shifted into, Hacked or Killed by anyone, unless by suicide.\
If the Medic reports a dead body, they can get a report containing clues to the Killer's identity.\
A report can contain the name of the killer or the color type (Darker/Lighter)
### Colors
- Red - Darker
- Blue - Darker
- Green - Darker
- Pink - Lighter
- Orange - Lighter
- Yellow - Lighter
- Black - Darker
- White - Lighter
- Purple - Darker
- Brown - Darker
- Cyan - Lighter
- Lime - Lighter
- Watermelon - Darker
- Chocolate - Darker
- Sky Blue - Lighter
- Beige - Darker
- Hot Pink - Lighter
- Turquoise - Lighter
- Rainbow - Lighter
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Medic | The percentage probability of the Medic appearing | Percentage | 0% |
| Show Shielded Player | Who should be able to see who is Shielded | Self / Medic / Self + Medic / Everyone | Self |
| Murder Attempt Indicator for Shielded Player | Whether the Shielded player gets an indicator when someone tries to Shift into, Hack or Kill them | Toggle | False |
| Show Medic Reports | Whether the Medic should get information when reporting a body | Toggle | True |
| Time Where Medic Reports Will Have Name | If a body has been dead for shorter than this amount, the Medic's report will contain the killer's name | Time | 0s |
| Time Where Medic Reports Will Have Color Type | If a body has been dead for shorter than this amount, the Medic's report will have the type of color | Time | 15s |

-----------------------
## Seer
### **Team: Crewmates**
The Seer is a Crewmate that can reveal the roles of other players.\
Based on settings, the Seer can find out whether a role is Good, Evil or Neutral, or they can find out the role itself.\
A player's name will change color to their team or role.\
If the Seer investigates someone, the Seer's name will change color to inform that player who the Seer is.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Seer | The percentage probability of the Seer appearing | Percentage | 0% |
| Seer Cooldown | The Cooldown of the Seer's Reveal button | Time | 25s |
| Info that Seer sees | Whether the Seer sees the Role or the Team of a player | Role / Team | Role |
| Who Sees That They Are Revealed | Which roles see the Seer's identity once the Seer has seen their role | Crewmates / Impostors + Neutral / All / Nobody | Crewmates |
| Neutrals show up as Impostors | When the Info is set to Team, Neutral roles show up as Red, like Impostors | Toggle | False |

-----------------------
## Child
### **Team: Crewmates**

The Child is a Crewmate that cannot be killed or voted out.\
If that does happen, everybody loses.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Child | The percentage probability of the Child appearing | Percentage | 0% |

-----------------------
## Spy
### **Team: Crewmates**

The Spy is a Crewmate that gains more information when on Admin Table and Vitals.\
On Admin Table, the Spy can see the colors of every person on the map.\
On Vitals, the Spy can see how long killed bodies have been dead for.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Spy | The percentage probability of the Spy appearing | Percentage | 0% |

-----------------------
## Snitch
### **Team: Crewmates**

The Snitch is a Crewmate that can get arrows pointing towards the Impostors, once all their tasks are finished.\
The names of the Impostors will also show up as red on their screen.\
Based on game settings, the Snitch may not know who they are until they have one task left.\
However, when they only have a single task left, the Impostors get an arrow pointing towards the Snitch.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Snitch | The percentage probability of the Snitch appearing | Percentage | 0% |
| Snitch knows who they are on Game Start | Whether the Snitch knows their role at the start of a game | Toggle | False |

-----------------------
# Neutral Roles
## Jester
### **Team: Neutral**
The Jester is a Neutral role with its own win condition.\
If they are voted out after a meeting, the game finishes and they win.\
However, the Jester does not win if the Crewmates, Impostors or another Neutral role wins.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Jester | The percentage probability of the Jester appearing | Percentage | 0% |

-----------------------
## Shifter
### **Team: Neutral**
The Shifter is a Neutral role with no win condition.\
They have zero tasks and are essentially roleless.\
However, they can swap roles with other players.\
Swapping roles with a custom role gives the Shifter their role and tasks and turns the other player into a Crewmate.\
Swapping roles with a Crewmate swaps tasks.\
Swapping roles with an Impostor fails and kills the Shifter.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Shifter | The percentage probability of the Shifter appearing | Percentage | 0% |
| Shifter Cooldown | The cooldown on the Shifter's Shift button | Time | 25s |
| Who gets the Shifter role on Shift | Who will receive the Shifter role upon getting Shifted into | Non-Impostors / Regular Crewmates / Nobody | Non-Impostors |

-----------------------
## The Glitch
### **Team: Neutral**

The Glitch is a Neutral role with its own win condition.\
The Glitch's aim is to kill __everyone__ and be the last person standing.\
The Glitch can Hack players, resulting in them being unable to report bodies and do tasks.\
Hacking prevents the hacked player from doing anything but walk around the map.\
The Glitch can Mimic someone, which results in them looking exactly like the other person.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| The Glitch | The percentage probability of The Glitch appearing | Percentage | 0% |
| Mimic Cooldown | The cooldown of The Glitch's Mimic button | Time | 30s |
| Mimic Duration | How long The Glitch can Mimic a player | Time | 10s |
| Hack Cooldown | The cooldown of The Glitch's Hack button | Time | 30s |
| Hack Duration | How long The Glitch can Hack a player | Time | 10s |
| Glitch Kill Cooldown | The cooldown of the Glitch's Kill button | Time | 30s |
| Initial Glitch Kill Cooldown | The cooldown of The Glitch's Kill button at the start of a game | Time | 10s |
| Glitch Hack Distance | How far away The Glitch can Hack someone from | Short / Normal / Long | Short |

-----------------------
## Executioner
### **Team: Neutral**

The Executioner is a Neutral role with its own win condition.\
Their goal is to vote out a player, specified in the beginning of a game.\
If that player gets voted out, they win the game.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Executioner | The percentage probability of the Executioner appearing | Percentage | 0% |
| Executioner becomes on Target Dead | Which role the Executioner becomes when their target dies | Crewmate / Jester | Crewmate |

-----------------------
## Arsonist
### **Team: Neutral**

The Arsonist is a Neutral role with its own win condition.\
They have the ability to douse other players with gasoline.\
Once they have doused every player remaining, they can Ignite everyone at once.\
Upon Igniting every player, they win the game.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Arsonist | The percentage probability of the Arsonist appearing | Percentage | 0% |
| Douse Cooldown | The cooldown of the Arsonist's Douse button | Time | 25s |
| Game keeps going so long as Arsonist is alive | Whether the game keeps going while the Arsonist remains | Toggle | False |

-----------------------
# Impostor Roles
## Janitor
### **Team: Impostors**
The Janitor is an Impostor that can clean up bodies.\
They can, however, not kill until they are the last Impostor remaining.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Janitor | The percentage probability of the Janitor appearing | Percentage | 0% |
| Janitor Clean Cooldown | The cooldown of the Janitor's Clean button | Time | 25s |

-----------------------
## Morphling
### **Team: Impostors**

The Morphling is an Impostor that can Morph into another player.\
At the beginning of the game and after every meeting, they can choose someone to Sample.\
They can then Morph into that person at any time for a limited amount of time.\
To balance the role, they can't vent.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Morphling | The percentage probability of the Morphling appearing | Percentage | 0% |
| Morph Cooldown | The cooldown of the Morphling's Morph button | Time | 25s |
| Morph Duration | How long the Morph lasts for | Time | 10s |

-----------------------
## Camouflager
### **Team: Impostors**

The Camouflager is an Impostor that can turn everyone into colorless characters.\
Everyone then goes grey for a certain period of time, along with their names disappearing, making them become unrecognizable.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Camouflager | The percentage probability of the Camouflager appearing | Percentage | 0% |
| Camouflage Cooldown | The cooldown of the Camouflager's Camouflage button | Time | 25s |
| Camouflage Duration | How long the Camouflage lasts for | Time | 10s |

-----------------------
## Miner
### **Team: Impostors**

The Miner is an Impostor that can create new vents.\
These vents only connect to each other, forming a new passway.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Miner | The percentage probability of the Miner appearing | Percentage | 0% |
| Mine Cooldown | The cooldown of the Miner's Mine button | Time | 25s |

-----------------------
## Swooper
### **Team: Impostors**

The Swooper is an Impostor that can temporarily turn invisible.\
To balance the role, they can't vent.

### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Swooper | The percentage probability of the Swooper appearing | Percentage | 0% |
| Swooper Cooldown | The cooldown of the Swooper's Swoop button | Time | 25s |
| Swooper Duration | How long the Swooping lasts for | Time | 10s |

-----------------------

# Modifiers
Modifiers are added on top of players' roles.
## Torch
### **Applied to: Crewmates**
The Torch's vision doesn't get reduced when the lights are sabotaged.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Torch | The percentage probability of the Torch appearing | Percentage | 0% |

-----------------------
## Diseased
### **Applied to: Crewmates**
Killing the Diseased triples the killer's Kill cooldown.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Diseased | The percentage probability of the Diseased appearing | Percentage | 0% |

-----------------------
## Flash
### **Applied to: All**
The Flash travels at twice the speed of a normal player.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Flash | The percentage probability of the Flash appearing | Percentage | 0% |

-----------------------
## Tiebreaker
### **Applied to: All**
If any vote is a draw, the Tiebreaker's vote will go through.\
If they voted another player, they will get voted out.\
If the Tiebreaker is the Mayor, it applies to the Mayor's __first__ vote.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Tiebreaker | The percentage probability of the Tiebreaker appearing | Percentage | 0% |

-----------------------
## Drunk
### **Applied to: All**
The Drunk's controls are inverted.
### Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Drunk | The percentage probability of the Drunk appearing | Percentage | 0% |

-----------------------
# Custom Game Options
| Name | Description | Type | Default |
|----------|:-------------:|:------:|:------:|
| Camouflaged Comms | Whether everyone becomes camouflaged when Comms are sabotaged | Toggle | False |
| Camouflaged Meetings | Whether everyone is camouflaged during meetings while Comms are sabotaged | Toggle | False |
| Impostors can see the roles of their team | Whether Impostors are able to see which Impostor roles their teammates have | Toggle | False |
| Dead can see everyone's roles | Whether dead players are able to see the roles of everyone else | Toggle | False |
| Max Impostor Roles | The maximum number of custom Impostor roles a game can have | Number | 1 |
| Max Neutral Roles | The maximum number of Neutral roles a game can have | Number | 1 |

-----------------------
## Extras
### New Colors!
New colors are added for crewmates to pick from: watermelon, chocolate, sky blue, beige, hot pink and turquoise.
### Rainbow Color!
A rainbow color has also been added. Anyone who equips this color will constantly switch between the colors of the rainbow.




# Bug / Suggestions
If you have any bugs or any need to contact me, join the [Discord server](https://discord.gg/bYSaT74KzT) or create a ticket on GitHub

# Credits & Resources
[Reactor](https://github.com/NuclearPowered/Reactor) - The framework of the mod\
[BepInEx](https://github.com/BepInEx) - For hooking game functions\
[Among-Us-Sheriff-Mod](https://github.com/Woodi-dev/Among-Us-Sheriff-Mod) - For the Sheriff role.\
[Among-Us-Love-Couple-Mod](https://github.com/Woodi-dev/Among-Us-Love-Couple-Mod) - For the inspiration of Lovers role.\
[ExtraRolesAmongUs](https://github.com/NotHunter101/ExtraRolesAmongUs) - For the Engineer & Medic roles.\
[TooManyRolesMods](https://github.com/Hardel-DW/TooManyRolesMods) - For the Investigator & Time Lord roles.\
[TorchMod](https://github.com/tomozbot/TorchMod) - For the inspirtation of the Torch Mod.\
[XtraCube](https://github.com/XtraCube) - For the RainbowMod.\
[PhasmoFireGod](https://twitch.tv/PhasmoFireGod) - Button Art.\
[TheOtherRoles](https://github.com/Eisbison/TheOtherRoles) - For the inspiration of the Child and Spy roles.

[Essentials](https://github.com/DorCoMaNdO/Reactor-Essentials) - For created custom game options.\
v1.0.3 uses [Essentials](https://github.com/DorCoMaNdO/Reactor-Essentials) directly.\
v1.1.0 uses a modified version of Essentials that can be found [here](https://github.com/slushiegoose/Reactor-Essentials).\
v1.2.0 has Essentials embedded and can be found [here](https://github.com/slushiegoose/Town-Of-Us/tree/master/source/Patches/CustomOption).
