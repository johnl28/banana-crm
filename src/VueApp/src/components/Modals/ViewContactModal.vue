<script lang="ts" setup>
import { useContactStorage } from '@/stores/contactStorage';
import { onMounted } from 'vue';

const contacts = useContactStorage();

const emits = defineEmits(['OnClose']);

const props = defineProps({
  showModal: { 
    type: Boolean,
    required: true
  },

  contactId: {
    type: Number,
    required: true
  }

});

onMounted(() => {
  //contacts.getContact(props.contactId);
});


function Close()
{
  emits("OnClose");
}

</script>


<template>
<div class="modal-bg" @click.self="Close" v-if="props.showModal">
  <div class="box-2">
    <div>

    </div>

    <div>

    </div>
  </div>
</div>
</template>


<style>
.modal-bg {
  position: fixed;
  left: 0;
  top: 0;

  height: 100%;
  width:100%;
  z-index: 99;

  background-color: rgba(0, 0, 0, 0.378);
}

.box-2 {
  display: flex;
  position: absolute;
  right: 0;
  top: 0;
  border-left: solid 1px var(--color-border);
  background-color: var(--color-background);
  width: 600px;
  height: 100%;
}
</style>