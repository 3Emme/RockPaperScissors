# _Rock, Paper, Scissors_ 🗿 📃 ✂️

#### _Recreate the game Rock, Paper, Scissors in C# Sept 13, 2020_

#### By _**Natalie Murphy & Emme Buentiempo**_

## Description

Recreate the game Rock, Paper, Scissors. For anyone who has never played it, here are the rules:

- It is played by 2 people. Each person chooses "Rock", "Paper", or "Scissors" by forming a shape with their hand.
- They choose at the same time, so that each person doesn't know what the other person has picked.
- If one person chooses "Rock" and the other person picks "Scissors" then "Rock" wins. It's a game of combinations:

```
Rock v. Scissors = Rock wins
Rock v. Paper = Paper wins
Paper v. Scissors = Scissors wins
```

- If both people choose the same thing, then it is a draw and nobody wins.

## Specs

Write a method that can handle the different combinations
Your method should take 2 inputs - one for each player's choice
It should return "Player 1" if the first input wins, "Player 2" if the second input wins, and "Draw" if nobody wins.

### specs for all possible combination of plays:
tie Spec:
if input == input2 = tie 
Scissor is superior paper
Paper is superior to rock 
Rock is superior ti scissor 

Always odd, in the case of 7 total, 3 from the choice is defeated and the following 3 defeat the choice. 
{0,1,2,3,4,5,6}
{0} - tie 
{1,2,3} defeat
{4,5,6} defeated

0 = scissor 1= paper  2= rock 

{0, 1, 2}

hero: 2
villian: 0 

0>2
villian array
{0,1,2}

hero array
{2,0,1}

2<0 
index ++ is always superior in a loop 

```
Input: Rock
Input 2:Rock
Output:Tie!
```

```
Input:Paper
Input 2: Paper
Output:Tie!
```

```
Input:Scissors
Input 2: Scissors
Output:Tie!
```

```
Input:Rock
Input 2:Paper
Output: Paper beats Rock!
Input 2 wins!
```

```
Input:Rock
Input 2:Scissors
Output: Rock beats Scissors!
Input Wins!
```

```
Input:Paper
Input 2: Scissors
Output: Scissors beats paper!
Input 2 Wins!
```

## Technologies Used

C#

### License



Copyright (c) 2020 **_Natalie Murphy & Emme Buentiempo_**
