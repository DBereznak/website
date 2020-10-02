<template>
    <section>
        <header id="top_section">
            <h1>Next-Level Web Development</h1>
            <p>Don’t settle for less than the best.</p>
        </header>
        <h3>Custom Web Development
</h3>
        <p>
Build your online presence with confidence, focusing on user-friendliness and good-looks.
From landing pages to stunning websites and beyond, Donny builds and maintains exquisite web pages on behalf of his clients.

        </p>
    </section>
</template>

<script>
export default {
    name: "Head",
      data: function() {
    return {
    }
  }
}
</script>

<style scoped>
h1{
   font-size: clamp(0.9rem, 1vw + 1rem, 2.2rem);
   font-weight: bold;
   color: #000; 
}
p{
    font-size: clamp(0.9rem, 1vw + 1rem, 2.2rem);
    font-style: italic;
    color: #000;
}
</style>