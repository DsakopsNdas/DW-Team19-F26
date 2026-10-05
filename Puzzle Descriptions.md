

***3x3 Sliding Puzzle:

Chosen image is broken into 8 Pieces while one square is empty. Players must move the pieces around into their correct positions. 

This could be accomplished in code via multiple if/then statements. Each piece would receive a “Name” such as A1; 

A rudimentary explanation would be this: 

If A1 is in the A1 Position then; 

A1_Correct == true; 

If A1_Correct == true; 

If A2 is in the A2 Position then; A2_Correct == true; 

And so on until all pieces A1 through A8 are true. Once they are all true, have a final check. 

If A1_Correct == true; If A2_Correct == true; If A3_Correct == true; If A4_Correct == true; If A5_Correct == true; If A6_Correct == true; If A7_Correct == true; If A8_Correct == true; Then slidingPuzzleComplete == true; 

If slidingPuzzleComplete == true; (somehow spawn in the ingredient_Asset associated with that puzzle) 



***Circle Puzzle: 

Rotation of circles 1-3 must be the same (So the top of each circle must align with the top of the circle before it), 



***Fire Puzzle: 

Players must pick up 3 different papers from the scorched table. 

Basically when player clicks on a paper, it disappears and a hidden count (sigilPapers++) goes up by one. 

When sigilPapers == 3 ~ the next time the player interacts with the table, all three papers will be placed on the table and form a sigil that the player needs to trace.



***Cypher Puzzle

Three different colors of crystals will be aligned on a shelf with a label under them in a different script.

Players need to choose the right crystal for the potion unless they wish to lose. Code for this isn't hard, basically the player can choose any of the crystals (or all of them) and have it in their 'inventory'. What matters is if they put the correct crystal inside of the cauldron.

At the start of the game, a line of code chooses between (Green, Red, and Blue). Whichever it chooses also dictates what the paper says. If it chooses Green, then the description for the Green crystal on the paper should be changed to say something along the lines of "it makes you smaller", while Blue and Red would receive a different description that doesn't matter.

The labels however, would not simply be the color of the crystal, but something different like "Emerald", "Ruby" and "Sapphire". The players would need to decipher the script on the labels via a different paper seen on the inside of the dresser which would help this process.

Code might look like:

hasGreenCrystal == false;
hasBlueCrystal == false;
hasRedCrystal == false;

(when picked up, turn false to 'true').