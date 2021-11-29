const express = require("express");
const options = require("./options");
const carRouter = require("./cars");

const app = express();

app.use(express.urlencoded({extended: false}));
app.use(express.json());

app.set("view engine", "ejs");
app.use(express.static('./public'));
app.use("/images", express.static('./files/img'));

app.use("/cars", carRouter);

app.all("*",(req, res)=>{
    res.render("NotFound404", {
        url: "../files/img/404.png",
        text: "Page not found"
    });
});

app.listen(options.port, ()=>{
    console.log(`http://localhost:${options.port}`);
});