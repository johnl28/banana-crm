import type { AxiosResponse } from "axios";
import { axiosInstance } from "./axiosInstance";

export default {

  async getContact(id: number): Promise<AxiosResponse>
  {
    return await axiosInstance.get(`contact/${id}`);
  },

  async getContacts(): Promise<AxiosResponse<Contact[]>>
  {
    return await axiosInstance.get<Contact[]>("contact");
  },

  async createContact(newContact: Contact): Promise<AxiosResponse>
  {
    return await axiosInstance.post("contact", newContact);
  }

}



