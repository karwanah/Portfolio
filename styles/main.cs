@font-face {
  font-family: "Sofia Pro";
  src: url("../../assets/SofiaProLight.woff2") format("woff2"), url("../../assets/SofiaProLight.woff") format("woff");
  font-weight: 300;
  font-style: normal;
  font-display: swap;
}
span {
  border-right: 0.05em solid;
  animation: caret 1s steps(1) infinite;
}

@keyframes caret {
  50% {
    border-color: transparent;
  }
}
/* Color Variables */
html body {
  max-width: 100%;
  overflow-x: hidden;
  background: #fff;
}

.container-wide {
  display: block;
  max-width: 1200px;
  margin-right: auto;
  margin-left: auto;
  padding-right: 24px;
  padding-left: 24px;
  -webkit-flex-wrap: wrap;
  -ms-flex-wrap: wrap;
  flex-wrap: wrap;
}

.column-left {
  width: 63%;
  float: left;
}

.column-right {
  width: 37%;
  float: right;
}

::placeholder {
  opacity: 0.5;
}

.header {
  margin-top: 100px;
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.divt {
  text-align: left;
}

#navbar {
  position: relative;
  padding-top: 20px;
  overflow: hidden;
  z-index: 9999;
}

nav {
  float: right;
  margin-top: 20px;
}

#navbar a {
  margin-left: 40px;
  color: #6e6d7a;
}

/* Name Logo Text */
a {
  font-size: 18px;
  text-decoration: none;
  font-family: Spartan, sans-serif;
  font-weight: 600;
}

/* portrait image */
#me {
  width: 350px;
  height: auto;
  border-radius:100%;
}

/* Image and Text */
#intro {
  height: 500px;
}

/* Hello text */
#textdiv {
  margin-top: 100px;
}

#introtext {
  color: #0d0c22;
  margin: 15px 0 30px;
  font-family: "Sofia Pro", sans-serif;
  font-size: 32px;
  position: relative;
  line-height: 32px;
  font-weight: 500;
}

/* Animated Text */
#text {
  margin: 10px 0;
  color: #0d0c22;
  font-family: "Sofia Pro", sans-serif;
  font-size: 42px;
  position: relative;
  line-height: 54px;
  font-weight: 600;
}

#introbutton {
  display: flex;
  flex-direction: row;
  justify-content: flex-start;
}

#introbutton a {
  margin-left: 0px;
  align-items: flex-start;
}

#introbutton button {
  margin-right: 100px;
}

#bottom {
  display: flex;
  align-items: center;
  justify-content: center;
  width: 100%;
  background: #fff;
  height: 150px;
  margin-top: 100px;
}

#bottom a {
  margin: 20px;
  width: 50px;
}

#bottom img {
  width: 50px;
}

#buttom nav {
  height: 100%;
}

#tech {
  display: flex;
  align-items: center;
  justify-content: center;
  width: 100%;
  height: 200px;
  background: #fff;
}

#box {
  display: flex;
  flex-direction: row;
  align-content: center;
  justify-content: center;
  width: 100%;
}

#projects {
  margin-top: 100px;
  margin-bottom: 100px;
  display: flex;
  align-items: center;
  justify-content: flex-start;
  width: 100%;
  height: 600px;
  background: #f6f5ff;
}

#h1text {
  margin-top: 100px;
  width: 100%;
  height: 50px;
  display: flex;
  align-items: center;
  justify-content: center;
}

#h1text h1 {
  font-family: Spartan, sans-serif;
  font-size: 24px;
}

#projectbox {
  width: 100%;
  display: flex;
  flex-direction: row;
  justify-content: center;
}

.card {
  margin: 10px;
  max-width: 300px;
}

#box img {
  height: 100px;
  margin: 50px;
  max-width: 200px;
}

#techtext {
  margin-top: 30px;
  font-size: 30px;
}

@media only screen and (max-width: 750px) {
  #name {
    display: none;
    font-size: 0px;
  }

  .navbar {
    margin-bottom: 80px;
  }

  #intro {
    flex-direction: column;
    justify-content: center;
    height: 650px;
  }

  #texdiv {
    flex-direction: column;
    left: 0px;
  }

  #text {
    font-size: 28px;
    line-height: 36px;
    font-weight: 600;
    margin: 30px 0;
    width: auto;
  }

  #introtext {
    font-size: 24px;
    line-height: 28px;
    font-weight: 500;
    left: 0px;
  }

  #name {
    font-size: 10px;
  }

  .navbar a {
    font-size: 14px;
  }

  #h1text h1 {
    font-size: 14px;
  }

  .divt {
    text-align: left;
  }
}
#btn1 {
  margin-top: 40px;
  margin-right: 24px;
  padding: 0 30px;
  border: 1px solid rgba(255, 125, 89, 0.2);
  border-radius: 5px;
  background-color: #fff;
  background-image: -webkit-gradient(linear, left top, right top, from(#ff8d4d), to(#f4494e));
  background-image: linear-gradient(90deg, #ff8d4d, #f4494e);
  box-shadow: 1px 1px 8px 1px rgba(0, 0, 0, 0.02), 3px 3px 15px 2px rgba(0, 0, 0, 0.04), 6px 6px 20px 4px rgba(0, 0, 0, 0.05);
  -webkit-transition: box-shadow 0.2s ease-in-out, color 0.2s ease-in-out, opacity 0.2s ease-in-out;
  transition: box-shadow 0.2s ease-in-out, color 0.2s ease-in-out, opacity 0.2s ease-in-out;
  font-size: 16px;
  line-height: 48px;
  font-weight: 600;
  text-decoration: none;
  cursor: pointer;
}

@media only screen and (max-width: 1000px) {
  #name {
    font-size: 0px;
    display: none;
    margin-right: 0px;
  }
}
@media only screen and (max-width: 800px) {
  #btn1 {
    font-size: 16px;
    margin-left: 12px;
    margin-right: 12px;
  }

  #box img {
    height: 50px;
    margin: 20px;
  }
}
@media only screen and (max-width: 1000px) {
  #me {
    bottom: 0px;
  }
}
#contact {
  height: auto;
  margin-top: 30px;
  margin-bottom: 30px;
  display: flex;
  align-items: center;
  justify-content: center;
}

form {
  max-width: 500px;
  margin-right: 0;
  margin-bottom: 24px;
  margin-left: auto;
  padding: 24px 20px;
  border-color: rgba(0, 0, 0, 0.1);
  border-radius: 5px;
  color: #5c5b66;
  font-size: 16px;
  line-height: 25px;
  text-align: left;
}

input {
  display: block;
  width: 100%;
  width: 350px;
  margin-bottom: 24px;
  padding: 24px 20px;
  border-color: rgba(0, 0, 0, 0.1);
  border-radius: 5px;
  color: #5c5b66;
  font-size: 16px;
  line-height: 25px;
  text-align: left;
}

textarea {
  display: block;
  width: 100%;
  width: 350px;
  min-height: 256px;
  margin-left: auto;
  padding-top: 10px;
  padding-right: 20px;
  padding-left: 20px;
  border: 2px solid rgba(0, 0, 0, 0.1);
  border-radius: 5px;
  color: #5c5b66;
  font-size: 16px;
  line-height: 25px;
  text-align: left;
}

@media only screen and (max-width: 479px) {
  nav {
    float: unset;
    text-align: center;
  }

  #navbar a {
    font-size: 16px;
    margin: 8px;
  }

  .column-left {
    width: 100%;
  }

  .column-right {
    width: unset;
    width: 100%;
  }

  .header {
    flex-direction: column;
    margin-top: 30px;
  }

  form {
    margin: unset;
  }

  #contact {
    display: unset;
  }

  textarea input {
    width: 250px;
    text-align: center;
  }

  .container-wide {
    padding-right: 16px;
    padding-left: 16px;
  }
}

/*# sourceMappingURL=main.cs.map */
