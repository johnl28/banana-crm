<script lang="ts" setup>
import { ref, onBeforeMount } from 'vue';

import { useAlertStorage } from '@/stores/alertStorage';
import { useContactStorage } from '@/stores/contactStorage';
import ViewContactModal from '@/components/Modals/ViewContactModal.vue';


const contactsStorage = useContactStorage();
const alertStorage = useAlertStorage();

const newUserForm = ref<Contact>({} as Contact);

const selectedContact = ref<number>(0);

onBeforeMount(() => {
  contactsStorage.initContacts();
})

function OnCloseModal()
{
  selectedContact.value = 0;
}

function OpenModal(id: number)
{
  selectedContact.value = id;
}

</script>


<template>
  <div>
    <div class="box">

      <input v-model="newUserForm.firstName" placeholder="First Name" type="text" />
      <input v-model="newUserForm.lastName" placeholder="Last Name" type="text" />
      <input v-model="newUserForm.email" placeholder="Email" type="text" />
      
      <button @click="contactsStorage.createContact(newUserForm)" class="btn-primary">Create</button>
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
        <tr v-for="contact, index in contactsStorage.contacts" :key="index" @click="OpenModal(contact.id)">
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

    <ViewContactModal @on-close="OnCloseModal" :show-modal="selectedContact != 0" :contact-id="selectedContact">
    </ViewContactModal>

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

.contacts-table tbody{
  border-radius: 20px;
}

.contacts-table td, tr {
  padding: 14px;
  border-bottom: solid 1px var(--color-border);

}

.contacts-table tr {
  margin-bottom: 20px;
  cursor: pointer;
}

.contacts-table tr:hover {
  outline: solid 1px var(--color-theme);
}

.box {
  padding: 26px;
  border: solid 1px var(--color-border);
  border-radius: 8px;
  margin-bottom: 30px;
}
</style>