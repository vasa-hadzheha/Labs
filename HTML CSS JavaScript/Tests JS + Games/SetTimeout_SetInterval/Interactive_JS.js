function timeUp(){
    alert("Time is up!")
}
var id = setTimeout(timeUp,4000);

let myElm = document.createElement("h1"); 
document.body.appendChild(myElm);
myElm.innerHTML = id; 
clearTimeout(id);


var counter = 1;
let sentece = document.createElement("p");
document.body.appendChild(sentece);
function printMessage(){
    sentece.innerHTML+= counter+"<br/>";
    counter++;
}
var intervalId = setInterval(printMessage,1000);

//setTimeout(clearInterval(intervalId),15000);
