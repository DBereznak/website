<template>
  <footer id="footer_section">
				<p>&copy; <span class="year">{{date.getFullYear()}}</span> Donny Bereznak</p>
	</footer> 
</template>

<script>
export default {
    name: "Footer",
      data: function() {
    return {
      date: new Date,
    }
  }
}
</script>

<style scoped>
footer{
  height: 150px;
  width: 100%;
  margin: 0;
  background: #400080;
  color: #fff;
}
footer p{
  padding-top: 75px;
}
</style>