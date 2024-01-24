document.getElementById("n0").focus();
let te=true;
document.forms[0].onsubmit = function(e){
let nam= document.getElementById("n0").value.trim();
let chnam= /\b[a-z|A-Z]/.test(nam);
let mob= document.getElementById("n1").value.trim();
let chmob= /01[0-9]{9}/.test(mob)&&mob.length===11;
let pass= document.getElementById("n2").value.trim();
let chpass= /[a-z|A-Z]{6,25}/.test(pass);
let repass= document.getElementById("n3").value.trim();
 let chrepas= pass===repass? true:false;

 if(chnam=== true&&chmob===true&&chpass===true&& chrepas===true)
 {
     te= false;
 }

if(te===true){
    e.preventDefault();
}

    
}