<script lang="ts" setup>
import { useContactStorage } from '@/stores/contactStorage';
import { ref, onBeforeMount } from 'vue';


const contactsStorage = useContactStorage();

const newUser = ref<Contact>({} as Contact);


onBeforeMount(() => {
  contactsStorage.initContacts();
})

</script>


<template>
  <div>
    <div>

      <input v-model="newUser.firstname" placeholder="First Name" type="text" />
      <input v-model="newUser.lastname" placeholder="Last Name" type="text" />
      <input v-model="newUser.email" placeholder="Email" type="text" />
      
      <button @click="contactsStorage.createContact(newUser)">Create</button>
    </div>

    <div v-for="contact, index in contactsStorage.contacts" :key="index">
      {{ contact.email }}
    </div>


    {{ contactsStorage.loading }}
  </div>
</template>