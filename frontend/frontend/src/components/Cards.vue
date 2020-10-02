<template>
<section id="cards_section">
<div class="card" v-for="card in cardsData" :key="card.count">
    <div class="card_image">
        <img :src="card.image" :alt="card.title" />
    </div>
    <div class="text_content">
        <h4>{{card.title}}</h4>
        <p>{{card.body}}</p>
    </div>
</div>
</section>
</template>

<script>
export default {
    name: "Cards",
      data: function() {
    return {
      cardsData: [
          {image: 'https://picsum.photos/175/300',
          title: 'Personal Attention',
          body: 'When you work with Donny Bereznak, you’re more than a number in a queue. You’re an esteemed client and friend guaranteed to receive personal care and attention-to-detail.', count: 1},
          {image: 'https://picsum.photos/175/300',
          title: 'Full Customization',
          body: 'No matter the size or nature of your business, work with Donny to build a custom site with eye-catching themes flawlessly tailored to your needs.', count: 2},
          {image: 'https://picsum.photos/175/300',
          title: 'Free Consultation',
          body: 'As part of Donny’s services, you’ll get to chat in-depth to shape a plan-of-action before starting anything a thing.', count: 3},
          {image: 'https://picsum.photos/175/300',
          title: 'Flexibility',
          body: 'Donny has the skills and experience needed to cut through common website issues like instability and slow speeds, in an effort to increase the time people spend on your website!', count: 4},
          
      ]
    }
  }
}
</script>

<style scoped>
.card{
    display: flex;
    flex-flow: row nowrap;
    margin: auto;
    padding: 50px;
}

.card .text_content{
    margin: 0 50px;
}

.card .text_content h4{
    margin-top: 0;
}

.card:nth-child(odd) .text_content h4{
    text-align: left;
}

.card:nth-child(odd) .text_content p{
    text-align: left;
    margin-right: 200px;
}


.card:nth-child(even){
    flex-direction: row-reverse;
}
.card:nth-child(even) .text_content {
    margin-right: 50px;
}
.card:nth-child(even) .text_content h4{
    text-align: right;
}
.card:nth-child(even) .text_content p{
    text-align: right;
    margin-left: 200px;
}
</style>