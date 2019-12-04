
class TTT {
        constructor() {
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
    init() {
        const sq = document.getElementsByName("square");

        for (let i = 0; i < sq.length; i++) {
            this.squares[i] = sq[i];
            sq[i].onclick = this.handleClick.bind(this, i);;
        }
    }
    handleClick(i) {

        
        const thisSquare = document.getElementById(i);
        
        if (this.xIsNext) {
            this.squares[this.id] = "X";
            thisSquare.innerHTML = "X";
            this.xIsNext = false;
            document.getElementById('status').innerHTML = "Next Player: 0";
        }
        else {
            this.squares[this.id] = "0";
            thisSquare.innerHTML = "0";
            this.xIsNext = true;
            document.getElementById('status').innerHTML = "Next Player: X";
        }
        this.onclick = () => { };
        if (this.calculateWinner() == true) {
            this.highlightWinner();
        }
        
    }

    calculateWinner() {
        for (let i = 0; i < this.lines.length; i++) {
            // const a,b,c = (lines[i][0],lines[i][1],lines[i][2]);
            let a = this.lines[i][0];
            let b = this.lines[i][1];
            let c = this.lines[i][2];
            if (this.squares[a] &&
                this.squares[a] === this.squares[b] &&
                this.squares[a] === this.squares[c]) {
                this.winner = this.squares[a];
                this.winningLine = this.lines[i];
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
        for (let i = 0; i < this.winningLine.length; i++) {
            const onesquare = document.getElementById(this.winningLine[i]);
            onesquare.classList.add('red');
        }
        this.disableAll();
    }

    disableAll() {
        let squareBoard = document.getElementById('square');
        for (let i = 0; i < this.squareBoard.length; i++) {
            squareBoard[i].onclick = () => { };
        }
    }
}

// declare a variable ttt
let ttt;
window.onload = () => { ttt = new TTT(); };
