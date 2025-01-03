<script lang="ts" setup>
import { useAlertStorage } from '@/stores/alertStorage';
import { computed } from 'vue';

const alertsStorage = useAlertStorage();

const activeAlert = computed(() => alertsStorage.alerts[0]);

</script>

<template>
  <div class="alerts" v-if="alertsStorage.isAlertActive">
    <div :class="['alert', activeAlert.type.valueOf()]">
      {{ activeAlert.message }}  
    </div>
<!-- 
    <div class="alert error">
      Error alert!  
    </div>
    <div class="alert warning">
      Warning alert!  
    </div>
    <div class="alert success">
      Success alert!  
    </div>
    <div class="alert info">
      Info alert!  
    </div> -->
  </div>

</template>

<style scoped>
.alerts {
  display: flex;
  flex-direction: column;
  gap: 5px;

  position: fixed;
  left: 50%;
  top: 0;
  padding: 30px;

  min-width: 20em;
  transform: translateX(-50%);
  z-index: 9;
}

.alert {
  animation: slide-down .3s;
  padding: 12px;
  border-radius: 4px;
  background-color: var(--color-background-mute);
  border: solid 1px var(--color-border);

  font-weight: bold;
}

.success {
  background-color: green;
}

.warning {
  background-color: orange;
}

.error {
  background-color: maroon;
  color: rgb(255, 136, 136);
}
</style>

