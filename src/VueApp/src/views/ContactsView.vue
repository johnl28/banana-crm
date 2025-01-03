<script lang="ts" setup>
import { ref, onBeforeMount } from 'vue';

import { useAlertStorage } from '@/stores/alertStorage';
import { useContactStorage } from '@/stores/contactStorage';
import { AlertType } from '@/constants';
import ViewContactModal from '@/components/Modals/ViewContactModal.vue';


const contactsStorage = useContactStorage();
const alertStorage = useAlertStorage();

const newUser = ref<Contact>({} as Contact);


onBeforeMount(() => {
  contactsStorage.initContacts();
})

</script>


<template>
  <div>
    <div class="box">

      <input v-model="newUser.firstName" placeholder="First Name" type="text" />
      <input v-model="newUser.lastName" placeholder="Last Name" type="text" />
      <input v-model="newUser.email" placeholder="Email" type="text" />
      
      <button @click="contactsStorage.createContact(newUser)" class="btn-primary">Create</button>
    </div>

    <table class="contacts-table">
      <thead>
        <tr>
          <td>
            ID
          </td>
          <td>
            Name
          </td>
          <td>
            Email
          </td>
          <td>
            Phone
          </td>
          <td>
            Note
          </td>
        </tr>
      </thead>


      <tbody>
        <tr v-for="contact, index in contactsStorage.contacts" :key="index">
          <td>
            {{ contact.id }}
          </td>
          <td>
            {{ contact.firstName }} {{ contact.lastName  }}
          </td>
          <td>
            {{ contact.email }}
          </td>
          <td>
            {{ contact.phone }}
          </td>
          <td>
            {{ contact.note }}
          </td>
        </tr>
      </tbody>
    </table>

    <ViewContactModal></ViewContactModal>

  </div>
</template>

<style scoped>
.contacts-table {
  width: 100%;
  border-collapse: collapse;
  border: solid 1px var(--color-border);
}

.contacts-table thead {
  background-color: var(--color-background-mute);
}

.contacts-table td, tr {
  padding: 14px;
  border-bottom: solid 1px var(--color-border);
  border-radius: 8px;

}

.contacts-table tr {
  margin-bottom: 20px;
}

.box {
  padding: 26px;
  border: solid 1px var(--color-border);
  border-radius: 8px;
  margin-bottom: 30px;
}
</style>