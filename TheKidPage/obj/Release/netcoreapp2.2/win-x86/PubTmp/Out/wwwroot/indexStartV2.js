// Create a class called TTT
class TTT
{ constructor() 
    {
        this.xIsNext = true;
        this.winner = null;
        this.squares = Array(9).fill(null);
        this.winningLine = Array();
        this.lines = [
            [0, 1, 2],
            [3, 4, 5],
            [6, 7, 8],
            [0, 3, 6],
            [1, 4, 7],
            [2, 5, 8],
            [0, 4, 8],
            [2, 4, 6],
            ];

            this.calculateWinner = this.calculateWinner.bind(this);
            this.init = this.init.bind(this);
            this.highlightWinner = this.highlightWinner.bind(this);
            this.disableAll = this.disableAll.bind(this);
            this.init();
     }
    init()
    {
            const sq = document.getElementsByName("square");
        
            for (let i = 0; i < sq.length; i++)
            {
                this.squares[i] = sq[i];
                sq[i].onclick = this.handleClick.bind(this, i);;
            }
    }
        handleClick(i){
        
                // Get the id from the square and put it in a variable
                // Remember that the id is an integer 0 - 8
                const thisSquare = document.getElementById(i);
                // Set the element in the squares array to the player's symbol
                // Update the inner html for this square in the UI
                // Set the onclick handler for this square in the UI to an empty anonymous function or arrow function
                // Update the variable xIsNext
                if(this.xIsNext)
                {
                    this.squares[this.id] = "X";
                    thisSquare.innerHTML = "X";
                    this.xIsNext = false;
                    document.getElementById('status').innerHTML = "Next Player: 0";
                }
                else
                {
                    this.squares[this.id] = "0";
                    thisSquare.innerHTML = "0";
                    this.xIsNext = true;
                    document.getElementById('status').innerHTML = "Next Player: X";
                }
                this.onclick = () => {};
                if (this.calculateWinner() == true)
                {
                    this.highlightWinner();
                    this.disableAll();
                }
                // If calculateWinner returns true
                // highlight the winner and disable all of the squares
                // otherwise update the status in the UI to display the player
            }
            
            calculateWinner() {
                for (let i = 0; i < this.lines.length; i++) {
                   // const a,b,c = (lines[i][0],lines[i][1],lines[i][2]);
                    let a = this.lines[i][0];
                    let b = this.lines[i][1];
                    let c = this.lines[i][2];       
                    if ((this.squares[a].innerHTML ==="X" || this.squares[a].innerHTML === "O") &&
                        this.squares[a].innerHTML === this.squares[b].innerHTML && 
                        this.squares[a].innerHTML === this.squares[c].innerHTML) {
                        this.winner = this.squares[a].innerHTML;
                        this.winningLine = this.lines[i].innerHTML;
                        return true;
                    }
                }
                this.winner = null;
                this.winningLine = Array();
                return false;
                
            }
            
            //
            highlightWinner() {
                document.getElementById('status').innerHTML = "Winner!";
                for (let i = 0; i < this.winningLine.length; i++)
                {
                    const onesquare = document.getElementById(this.winningLine[i]);
                    onesquare.classList.add('red'); 
                }
                this.disableAll();
            }
            
            disableAll() {
                let squareBoard = document.getElementById('square').innerHTML;
                for (let i = 0; i < this.squareBoard.length; i++)
                {
                    squareBoard[i].onclick = () => {};
                }
            }
} 

    /*
        Add a constructor that 
        -   defines and initializes all variables
        -   binds the keyword this to the class for each function because
            this will otherwise will refer to the clicked square
            -   this.calculateWinner = this.calculateWinner.bind(this);
            -   DON'T bind this for handleClick at this point
        -   calls the init method
    */

    /*
        Convert each function to a method
        -   move it inside the class
        -   remove the keyword function
        -   add this to all of the variables that belong to the class
        -   change var to let or const for local variables
        -   add this to all method calls
     
        Init
        -   bind both this and i to handleClick
            -   this.handleClick.bind(this, i);

        CalculateWinner
        -   use destructuring assingment to assign values to
            a b and c in one line

        HandleClick
        -   add a parameter i rather than getting i from this
            -   this now refers to the class not the square
        -   remove the local variable i
        -   add a local variable to refer to the clicked square
            -   remember that squares have an integer id 0 - 8
    */


// declare a variable ttt
let ttt;
window.onload = () => { ttt = new TTT();};

// add an onload handler to the window that assigns ttt to a TTT