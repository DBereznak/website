<template>
    <form id="contact_section" @submit.prevent="sendMail">
      <h3>To learn more about Donny’s services and how you can start working together today, fill
out the form below. Donny strives to respond as soon as possible.</h3>
        <input placeholder="Name" name="user_name" v-model="user_name"/>
        <input placeholder="Email" name="user_email" v-model="user_email" required/><br>
        <textarea class="textarea" rows="5" name="user_comment" v-model="user_comment" placeholder="Comments or Questions" required>
          </textarea><br>
        <input type="submit" value="Submit">  <br>
            <span id="message" class="message">{{showMessage}}</span>
    </form>
</template>

<script>
import emailjs from 'emailjs-com';

export default {
    name: "ContactForm",
    data: function() {
    return {
      user_name: '',
      user_email: '',
      user_comment: '',
      theMessage: '',
    }
  },
  computed: {
    showMessage: function () {
      let displayedMessage = this.theMessage;
      return displayedMessage;
    }
  },
  methods: {
    sendMail: function(event){
      emailjs.sendForm('service_p30qvei', 'template_c532k1j', event.target, 'user_na7MaXLkxg7rHaiTybYS3')
      .then(result => {
        document.getElementById("message").classList.add("success");
        this.theMessage = 'Your mail was sent successfully.';
        this.showMessage();
      }, error => {
        this.theMessage = 'There was an error sendiong your mail.'
        this.showMessage();
      });
    }
  }
}
</script>

<style scoped>
   form{
       width: 95%;
       max-width: 700px;
       margin: 30px auto;
       padding: 20px;
       border-top: 1px solid #999999;
   }
   form input {
     margin: 10px 20px;
     padding: 7px;
     width: 41%;
     height: 35px;
     background-color: #bfbfbf;
     border: 2px solid #bfbfbf;
     border-radius: 6px;
     color: #282828;
     font-size: 18px;
   }

   textarea{
    margin: 10px;
    padding: 7px;
    width: 90%;
    height: 200px;
    background-color: #bfbfbf;
    border: 2px solid #bfbfbf;
    border-radius: 6px;
    color: #282828;
    font-size: 18px;
   }

   form input:focus{
     border: 2px solid #282828;
   }

   form button {
    margin: 10px;
    padding: 7px;
    width: 200px;
    height: 50px;
    background-color: #807fac;
    border: 2px solid #807fac;
    border-radius: 6px;
    color: #282828;
    font-size: 18px;
    transition: all 0.2s;
   }

   form button:hover, form button:active{
     transition: all 0.2s;
     background-color: #c7c7c7;
   }
   form span.success{
     color:forestgreen;
   }
  
  form span.error{
     color: red;
   }
</style>