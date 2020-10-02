<template >
  <ul>
      <li v-for="item in menu" v-on:click="scrollPage" :class="item.link" :key="item.link">
          {{item.title}}
      </li>
  </ul>
</template>

<script>
export default {
    name: "NavMenu",
      data: function() {
    return {
      menu: [
          {title: "Welcome", link: "top_section"},
          {title: "About", link: "cards_section"},
          {title: "Get in touch", link: "contact_section"},
      ]
        
    }
  },
    methods: {
      scrollPage: function (event) {
        let menuList = document.querySelectorAll('div.left li');
        menuList.forEach(item => {
          item.classList.remove('selected');
        });
        let id = event.path[0].className;
        let el = document.getElementById(id);
        let selected = document.querySelector('.'+id);
        selected.classList.add('selected');
        let elPos = el.getBoundingClientRect();
        window.scrollTo({top: elPos.top, behavior: "smooth"});
      }
    }
}
</script>

<style scoped>
ul{
  list-style: none;
}
ul li {
  color: #fff;
  font-size:16px;

}
.selected{
 font-weight: bold;
}
</style>