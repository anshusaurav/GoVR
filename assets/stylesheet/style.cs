/* http://meyerweb.com/eric/tools/css/reset/ 
   v2.0 | 20110126
   License: none (public domain)
*/
html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
}

/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure,
footer, header, hgroup, menu, nav, section {
  display: block;
}

body {
  line-height: 1;
}

ol, ul {
  list-style: none;
}

blockquote, q {
  quotes: none;
}

blockquote:before, blockquote:after,
q:before, q:after {
  content: "";
  content: none;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

*, *:before, *:after {
  box-sizing: border-box;
}

html {
  font-size: 16px;
}
@media all and (max-width: 768px) {
  html {
    font-size: 12px;
  }
}

body {
  line-height: 1.5;
}

a {
  text-decoration: none;
  outline: none;
}

input,
button,
textarea {
  outline: 0;
  box-shadow: none;
  background-color: transparent;
}

img {
  font-size: 0;
  object-fit: cover;
}

.header .side-menu-links label, .header .menu-links a, .header .header-nav, .header .menu-links, .header .side-menu-links {
  display: flex;
  flex-wrap: wrap;
}

.game-List-Area .gamegrid-game, .services-text, .services-article, .vr-devices-demo .category-vr-slider, .vr-devices-demo .featured-category-devices, .game-demo .category-game-slider, .game-demo .featured-category, .hero .small-gallery .gal-item, .hero .small-gallery, .hero .hero-text {
  display: grid;
}

h1 {
  font-size: 2.5rem;
}
@media all and (max-width: 768px) {
  h1 {
    font-size: 3.5rem;
  }
}

h2 {
  font-size: 1.5rem;
  margin-bottom: 1.25rem;
}

h3 {
  font-size: 1.25rem;
  margin-bottom: 1.25rem;
}

h4 {
  font-size: 1.125rem;
  margin-bottom: 1.25rem;
}

h5 {
  font-size: 1rem;
  margin-bottom: 1.25rem;
}

h6 {
  font-size: 0.75px;
  margin-bottom: 1.25rem;
}

p {
  font-size: 1.25rem;
  margin-bottom: 1.25rem;
}

.btn {
  font-size: 1rem;
  padding: 1rem 2rem;
  text-transform: uppercase;
  cursor: pointer;
}

.padding {
  padding: 4rem 0;
}

.center {
  text-align: center;
}

.text-center {
  text-align: center;
}

.quote-marks {
  font-size: 8rem;
  height: 150px;
}

.img-responsive {
  width: 100%;
  font-size: 0;
}

.img-res {
  width: 100%;
  font-size: 0;
}

.container {
  max-width: 1400px;
  margin: 0 auto;
}
@media all and (max-width: 1024px) {
  .container {
    max-width: 900px;
    margin: 0 auto;
  }
}

body {
  font-family: "Montserrat", serif;
}

.header {
  padding: 1rem 0;
}
.header .header-nav, .header .menu-links, .header .side-menu-links {
  justify-content: space-between;
  align-items: center;
}
.header .logo {
  position: relative;
  z-index: 10;
}
.header .logo h1 {
  font-family: "Montserrat", serif;
  color: #21293f;
  background-image: -webkit-linear-gradient(#76b7ec, #333);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  background-image: linear-gradient(#76b7ec, #333);
  -moz-background-clip: text;
  -moz-text-fill-color: transparent;
  font-weight: 700;
}
.header .menu-links a {
  justify-content: space-between;
  color: #000000;
  font-size: 1rem;
  margin-left: 20px;
  font-family: "Montserrat", serif;
}
.header .side-menu-links label {
  justify-content: space-between;
  color: #000000;
  font-size: 1rem;
  margin-left: 20px;
  font-family: "Montserrat", serif;
}
.header .ham-menu {
  display: none;
}
.header .menu-support {
  text-align: center;
  line-height: 1rem;
  margin-left: 0.5rem;
  margin-right: 1rem;
}
@media all and (max-width: 768px) {
  .header {
    padding: 2.7rem;
  }
  .header .menu-links {
    display: none;
  }
  .header .side-menu-links {
    display: none;
  }
  .header .ham-menu {
    display: inline-block;
    position: relative;
    z-index: 10;
    color: #131722;
  }
  .header #toggle {
    display: none;
  }
  .header .ham:checked ~ .menu-links {
    display: inline-block;
    position: absolute;
    top: 0;
    left: 50%;
  }
  .header .ham:checked ~ .menu-links ul {
    width: 100%;
  }
}

.hero {
  background-image: url(../media/images/slider-8-1.jpg);
  background-size: cover;
  background-attachment: fixed;
  width: 100%;
}
.hero .hero-text {
  color: #ffffff;
  letter-spacing: 2px;
  padding: 15rem 0;
  align-items: center;
  grid-template-columns: 1fr 1fr;
}
@media all and (max-width: 768px) {
  .hero .hero-text {
    grid-template-columns: 1fr;
  }
}
.hero .hero-text h2 {
  font-size: 4rem;
  font-weight: 800;
  line-height: 2;
  letter-spacing: 0.5rem;
}
@media all and (max-width: 768px) {
  .hero .hero-text h2 {
    font-size: 4rem;
    text-align: center;
  }
}
.hero .hero-gallery h3 {
  font-size: 1.2rem;
  font-weight: 500;
  line-height: 2;
  letter-spacing: 0.12rem;
}
.hero .small-gallery {
  grid-template-columns: repeat(3, minmax(150px, 1fr));
  grid-auto-rows: min-content;
  grid-gap: 0.5rem;
  overflow: hidden;
}
.hero .small-gallery .gal-item {
  grid-template-columns: 1;
  grid-template-rows: 1;
}
.hero .small-gallery .gal-item .gal-item img {
  grid-column: 1/-1;
  grid-row: 1/-1;
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.game-demo {
  background-color: #131722;
}
.game-demo .featured-category {
  grid-gap: 2rem;
  grid-template-columns: repeat(4, minmax(16rem, 1fr));
}
.game-demo .category-game-slider {
  align-items: center;
}
.game-demo h4 {
  text-align: center;
  color: #ffffff;
}
.game-demo h3 {
  color: #ffffff;
  text-align: center;
}
.game-demo p {
  color: #66696C;
  text-align: center;
  font-size: 0.8rem;
}
.game-demo .slider-btn {
  cursor: pointer;
  background-color: transparent;
  border: 2px solid #ffffff;
  color: #ffffff;
  width: 2rem;
  height: 2rem;
  border-radius: 50%;
  margin-top: 1rem;
  font-family: inherit;
  letter-spacing: 1px;
}
.game-demo .slider-btn-div {
  text-align: center;
  align-self: start;
}
.game-demo .game-slider-dec-one {
  height: 0.1rem;
  background-image: linear-gradient(to right, #66696C 20%, #131722 80%);
  grid-column: 1/-1;
}
.game-demo .game-slider-dec-two {
  height: 0.1rem;
  margin-top: 1rem;
  background-image: linear-gradient(to right, #131722 20%, #66696C 80%);
}
@media all and (max-width: 768px) {
  .game-demo .featured-category {
    grid-gap: 2rem;
    grid-template-columns: 1fr;
  }
  .game-demo .featured-category .category-game:nth-child(2) {
    display: none;
  }
  .game-demo .featured-category .category-game:nth-child(3) {
    display: none;
  }
}

.vr-devices-demo {
  background-color: #000000;
}
.vr-devices-demo .featured-category-devices {
  grid-gap: 2rem;
  grid-template-columns: 1fr 3fr;
}
.vr-devices-demo .category-vr-slider {
  align-items: center;
}
.vr-devices-demo h4 {
  text-align: center;
  color: #ffffff;
}
.vr-devices-demo h3 {
  color: #ffffff;
  text-align: center;
}
.vr-devices-demo p {
  color: #66696C;
  text-align: center;
  font-size: 0.8rem;
}
.vr-devices-demo .slidervr-btn {
  cursor: pointer;
  background-color: transparent;
  border: 2px solid #ffffff;
  color: #ffffff;
  width: 2rem;
  height: 2rem;
  border-radius: 50%;
  margin-top: 1rem;
  font-family: inherit;
  letter-spacing: 1px;
}
.vr-devices-demo .slider-vrbtn-div {
  text-align: center;
  align-self: start;
}
.vr-devices-demo .game-slider-dec-one {
  height: 0.1rem;
  background-image: linear-gradient(to right, #66696C 20%, black 80%);
  grid-column: 1/-1;
}
.vr-devices-demo .game-slider-dec-two {
  height: 0.1rem;
  margin-top: 1rem;
  background-image: linear-gradient(to right, black 20%, #66696C 80%);
}

.services-article {
  grid-column-gap: 6rem;
}
.services-article .services-img {
  grid-column: 2/span 2;
  font-size: 0;
}
.services-article .services-img img {
  width: 100%;
}

.services-text {
  grid-column: 1/span 1;
  background: #af9453;
}
.services-text div {
  place-self: center;
}
.services-text h2 {
  font-size: 1.7rem;
  text-transform: uppercase;
  color: #ffffff;
  letter-spacing: 0.8rem;
  padding: 1rem 0;
}
.services-text p {
  line-height: 2;
  font-size: 1.5rem;
  color: #ffffff;
  padding: 1rem 0;
}
.services-text .btn {
  cursor: pointer;
  background-color: transparent;
  border: 2px solid #ffffff;
  color: #ffffff;
  margin-top: 1rem;
  font-family: inherit;
  letter-spacing: 1px;
}
.gallery-article .services-text {
  grid-column: 3/span 1;
}

.btn:hover {
  color: #76b7ec;
}

.slider-btn:hover {
  color: #76b7ec;
}

.footer {
  background-color: #131722;
}
.footer .footer-wrapper p {
  color: white;
  text-align: center;
  font-size: 0.75rem;
}

.small-padding {
  padding: 0.5rem 0;
}

@media all and (max-width: 768px) {
  .padding {
    padding: 0;
  }

  .header {
    padding: 2.7rem;
  }
  .header .menu-links {
    display: none;
  }
  .header .ham-menu {
    display: inline-block;
    font-size: 3rem;
    z-index: 10;
    font-weight: 700;
    cursor: pointer;
  }
  .header #toggle {
    display: none;
  }
  .header .ham-menu:checked ~ .menu-links {
    background: rgba(0, 0, 0, 0.9);
    display: inline-block;
    position: absolute;
    top: 0;
    right: 0;
    width: 100%;
    height: 100%;
    text-align: center;
    padding-top: 30vh;
  }
  .header .ham-menu:checked ~ .menu-links li {
    margin-bottom: 3rem;
  }
  .header .ham-menu:checked ~ .menu-links li a {
    color: #ffffff;
    font-size: 2rem;
  }

  .services-article {
    grid-auto-flow: row;
  }
  .services-article .services-img {
    grid-column: 1/span 4;
  }

  .services-text {
    grid-column: 1/span 4;
    padding: 4rem 0;
  }

  .text-hidden {
    display: none;
  }

  .hidden {
    display: inline-block;
  }
}
.game-List-Area {
  background-color: #21293f;
  background-repeat: no-repeat;
  background-size: cover;
  min-height: 90vh;
  color: #31030b;
}
.game-List-Area .game-List {
  width: 50%;
  padding: 0 auto;
}
.game-List-Area .gamegrid-game {
  grid-template-columns: 1fr;
  border: 2px solid black;
  grid-gap: 1rem;
}
.game-List-Area .gamegrid-game .game {
  padding: 1rem;
}

/*# sourceMappingURL=style.cs.map */
