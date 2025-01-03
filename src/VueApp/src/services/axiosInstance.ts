import axios from "axios";

import { AlertType } from "@/constants";
import { useAlertStorage } from "@/stores/alertStorage";

export const axiosInstance = axios.create({
  baseURL: "http://localhost:5206",
  timeout: 10000,
});



axiosInstance.interceptors.response.use(
  (response) => response,
  (error) => {
    const alertStorage = useAlertStorage();

    alertStorage.pushAlert({ message: error, type: AlertType.ERROR } );
    console.error(error);

    return Promise.reject(error);
  }
)
