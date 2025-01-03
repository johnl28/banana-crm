import { computed, ref } from "vue";
import { defineStore } from "pinia";
import { ALERT_LIFE_TIME } from "@/constants";


export const useAlertStorage = defineStore('Alert', () => {
  const alerts = ref<Alert[]>([] as Alert[]);
  const activeAlerts = computed(() => alerts.value.length);
  const isAlertActive = computed(() => activeAlerts.value > 0);


  function pushAlert(alert: Alert)
  {
    if(alert.durration === undefined)
    {
      alert.durration = ALERT_LIFE_TIME;
    }

    alerts.value.push(alert);

    setTimeout(() => {
      alerts.value.splice(activeAlerts.value - 1, 1);
    }, alert.durration);
  }

  return { pushAlert, alerts, activeAlerts, isAlertActive }
});

