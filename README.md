# WordleSolver
A Wordle solver app, for kicks and giggles

### Definitions: ###
- Possible/Potential Solution: Valid solutions for the game. There are some words that are excluded, like plurals ending with an **S**, verbs ending with **ED**, vulgarities, uncommon words, etc. which won't be solutions, so are not included in the list.
- Possible/Potential Guess: Valid guesses in the game, includes more words than known potential solutions.

## Notes for self: ##

### Issues to be created/solved: ###
-The solution list is out of date, as some recent solutions weren't in the original solution list.

### Possible future improvements: ###
- frequency count of words in remaining potential solutions
- suggestions for placements of letters in frequency count
- suggestions for which potential solutions/guesses that would minimize steps to solution
- Make use of the potential guesses to offer guesses that may not be solutions and for where the analyzed puzzle's solution is not in the known solution list.
- option to omit previous solutions from solutions (default off?)
- different interface (Chrome extension?) or ability to paste in copied page from NYT which would recognize the prevoius guesses

### Resources for future use: ###
- PossibleGuesses.txt in project, from the source
- past solutions: https://www.fiveforks.com/wordle/
- idea: check wordlebot for list of potential solutions, if it uses one
