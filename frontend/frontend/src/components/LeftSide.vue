<template>
<div class="left">
<h1>{{name}}</h1>
<NavMenu/>
</div>
</template>

<script>
import NavMenu from './NavMenu.vue';

export default {
    name: "LeftSide",
    components: {
        NavMenu
    },
    props: {
        name: String
    }
}
</script>

<style scoped>
.left{
width: 400px;
height: 100vh;
background-image: url(https://picsum.photos/800/400);
background-position: top left;
background-origin: content-box;
background-size: cover;
background-repeat: no-repeat;
position: fixed;
}

@media only screen and (max-width: 1200px) {
 .left{
   display: none;
   visibility: hidden;
   width: 0;
   height: 0;
   opacity: 0;
 }
}
</style>