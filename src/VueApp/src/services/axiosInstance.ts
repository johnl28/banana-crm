import axios from "axios";


export const axiosInstance = axios.create({
  baseURL: "http://localhost:5206",
  timeout: 10000,
});


