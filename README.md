# Bowling Game
 Bowling game exercise
 
# PROJECT OBJECTIVE
Bowling is a game where people try to knock down ten pins by rolling a ball. You are going to design a page,
and algorithm to score a game of bowling for one person. How input and output is handled is up to you. It
can be hard-coded rolls, random rolls, or a console app. You can complete the solution in a language of your
choice, however, we prefer either C# or JavaScript/TypeScript. An example set of rolls and final score has been
provided for you at the end.

# GAME RULES
The game consists of 10 frames. Each frame is composed of up to two rolls.
The tenth frame is special and is composed of up to three rolls. If the first roll is a strike then the player will roll
two more times. If the second roll is a strike or spare then the player will roll a third time.
The final game score is a sum of all frame scores.
A frame score is a sum of all the pins knocked down during the rolls with two exceptions. The 'spare' and the
'strike' are special scoring conditions.
A spare is when the first roll knocks down less than ten pins and the second roll knocks down the remaining
pins. A spare is calculated as 10 plus the number of pins knocked down on the next roll.
• For example: On frame 1 the player rolls a 9 and then a 1 which results in a spare. On frame 2 their first
roll is a 5 which makes the score for frame 1 a 15 (10+5).
A strike is when a roll knocks down all ten pins. The frame score is calculated as 10 plus the next two rolls.
• Example 1: On frame 1 the player rolls a 10 (strike). On frame 2 the player rolls an 8 and a 1. The score
for frame 1 is 19 (10+8+1).
• Example 2: On frame 10 the player rolls a strike. Their next two rolls are also strikes. Score for the frame
is 30 (10+10+10).
