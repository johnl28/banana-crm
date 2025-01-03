<script setup lang="ts">
import { RouterView } from 'vue-router'

import TheNavbar from './components/Static/TheNavbar.vue'
import UserStatus from './components/UserStatus.vue';
import TheAlert from './components/Static/TheAlert.vue';
</script>

<template>
  <header>
    <UserStatus></UserStatus>
    <TheNavbar></TheNavbar>
  </header>

  <main>
    <TheAlert></TheAlert>
    <RouterView />
  </main>

</template>

<style lang="scss" scoped>

header {
  width: 300px;
  height: 100vh;
  padding: 16px;
  border-right: solid 1px var(--color-border);
  // background-color: rgb(19, 19, 19);
  position: sticky;
  top: 0;
}

main {
  display: flex;
  flex-direction: column;
  padding: 26px;
  flex: 1;
}

</style>
