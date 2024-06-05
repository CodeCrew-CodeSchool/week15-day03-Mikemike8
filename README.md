# Intro to .Net

## Assignment: Tic-Tac-Toe

Read this document, in it's entirety before starting the assignment.

#### Overview
For this assignment, you will create a two (2) person, turn based Tic-Tac-Toe program.
Building off of your starter code provided from the class repo, complete the Tic Tac Toe logic. Refer to the "Submit this Assignment" section below on instructions with the starter code.

## Program Specifications



A Game board, to a user, looks like this:

```text
|1||2||3|
|4||5||6|
|7||8||9|
```

The numbers in each of the squares will indicate the position number. Prompt the user to
select which position they wish to
play and then replace that position with either an `X` or an `O`.

A winning board may look like this (O Wins!):

```text
|X||X||O|
|4||O||X|
|O||X||9|
```

Remember that Tic-Tac-Toe is a 2 player game, so be sure to "switch" between players.

Make it known to the user that their turn is over and it's time for the next players turn. You will both play on
the same board.

 Here is an outline for different classes that you have:

- Game Board (this should construct/display the board after every turn with it's new // Check rows
    if ((cells[0] == marker && cells[1] == marker && cells[2] == marker) ||
        (cells[3] == marker && cells[4] == marker && cells[5] == marker) ||
        (cells[6] == marker && cells[7] == marker && cells[8] == marker))
    {
        return true;
    }

    // Check columns
    if ((cells[0] == marker && cells[3] == marker && cells[6] == marker) ||
        (cells[1] == marker && cells[4] == marker && cells[7] == marker) ||
        (cells[2] == marker && cells[5] == marker && cells[8] == marker))
    {
        return true;
    }

    // Check diagonals
    if ((cells[0] == marker && cells[4] == marker && cells[8] == marker) ||
        (cells[2] == marker && cells[4] == marker && cells[6] == marker))
    {
        return true;
    }

    return false;state)
- Player (This will hold the players information such as name or marker, in addition to any
actions that user may take)
- Game (This would hold the actions of the game. )
- Position (the individual game board positions )

Be sure to check for a winner after each turn. Be aware that it is possible to have a tie/draw if no winner can be determined and all
marks on the board are occupied.

Stay within scope of this project. Please only use concepts and resources that we have covered
so far in previous labs/lectures/assigned pre-work.
If you are unsure if it is within scope, please ask a TA or instructor.
