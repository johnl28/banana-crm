<script lang="ts" setup>



</script>


<template>
<div class="modal-bg">
  <div class="box-2">
    
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