<script lang="ts" setup>

</script>

<template>
  <div class="nav-user">
    <div class="avatar">

    </div>

    <div class="user-details">
      <div class="user-name">
        Guest
      </div>
      <div class="user-email">
        guest@mail.com
      </div>
    </div>
  </div>
</template>

<style lang="scss">

.nav-user {
  display: flex;
  align-items: center;
  border-radius: 5px;
  border: solid 1px var(--color-border);
  // background-color: var(--color-background-soft);
  gap: 10px;
  padding: 16px;
}

.user-details {
   
}

.nav-user .avatar {
  width: 60px;
  height: 60px;
  background-color: var(--color-background-mute);
  border-radius: 100vh;
}

.user-name {
  font-weight: bold;
  font-size: large;
}
</style>