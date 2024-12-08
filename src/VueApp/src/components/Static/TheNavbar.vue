<script lang="ts" setup>
import { RouterLink } from 'vue-router';
import HomeIcon from '../icons/HomeIcon.vue';
import ContactsIcon from '../icons/ContactsIcon.vue';
import DateRangeIcon from '../icons/DateRangeIcon.vue';
</script>

<template>
  <nav>
    <RouterLink to="/" :active="$route.name == 'home'">
      <HomeIcon class="icon" /> Home
    </RouterLink>

    <RouterLink to="/contacts" :active="$route.name == 'contacts'">
      <ContactsIcon class="icon"/> Contacts
    </RouterLink>

    <RouterLink to="/projects" :active="$route.name == 'projects'">
      <DateRangeIcon class="icon"/> Projects
    </RouterLink>
    
  </nav>
</template>

<style lang="scss" scoped>

nav {
  display: flex;
  flex-direction: column;
  justify-content: center;
  gap: 5px;
  margin-top: 16px;
}

nav a {
  display: flex;
  align-items: center;
  font-weight: 500;
  color: var(--color-link);
  text-decoration: none;
  padding: 8px;
  border-radius: 5px;
  // border: solid 1px var(--color-border);
}

nav a:hover {
  color: var(--color-link-active);
  background-color: var(--color-background-mute);
}

nav a[active=true] {
  color: var(--color-theme);
  background-color: var(--color-background-soft);
}

.icon {
  margin-right: 10px;
  width: 18px;
  height: 18px;
}
</style>


