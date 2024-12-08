import { ref } from 'vue';
import { defineStore } from 'pinia';
import contactsService from '@/services/contactsService';

export const useContactStorage = defineStore('contacts', () => {

  const contacts = ref<Contact[]>([]);
  const loading = ref<boolean>(false);

  async function initContacts() {
    loading.value = true;
    const newContacts = await contactsService.getContacts();

    loading.value = false;
    contacts.value = newContacts.data;
  }

  async function createContact(newContact: Contact) {
    loading.value = true;

    await contactsService.createContact(newContact);

    contacts.value.push(newContact);

    loading.value = false;

  }

  return { contacts, loading, initContacts, createContact }
})


