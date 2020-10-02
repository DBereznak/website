<template>
  <div id="app">
    <div class="container">
      <div id="left">
        <LeftSide name="Donny Bereznak"/>
      </div>
      <div id="right">
        <Head/>
        <Cards/>
        <ContactForm/>
        <Footer/>
      </div>
    </div>
    
  </div>
</template>

<script>
import LeftSide from './components/LeftSide.vue';
import Cards from './components/Cards.vue';
import ContactForm from './components/ContactForm.vue';
import Footer from './components/Footer.vue';
import Head from './components/Head.vue';

export default {
  name: 'app',
  components: {
    LeftSide,
    Head,
    Cards,
    ContactForm,
    Footer
  }
}
</script>

<style>
body{
  margin: 0;
  padding: 0;
}
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

.container{
  display: flex;
  flex-flow: row nowrap;
  justify-content: space-between;
}

#left{
  max-width: 400px;
  width: 20%;
  margin-right: 20px;
}

#right {
  margin: 0;
}

section{
  width: 90%;
  max-width: 1200px;
  margin: 0 auto;

}
@media only screen and (min-width: 1600px) {
 #right{
   width: 80%;
 }
}
@media only screen and (max-width: 1599px) {
 #right{
   width: 70%;
 }
}
@media only screen and (max-width: 1200px) {
 #left{
  display: none;
   visibility: hidden;
   width: 0;
   height: 0;
   opacity: 0;
 }
#right{
   width: 100%;
 }
}
</style>
