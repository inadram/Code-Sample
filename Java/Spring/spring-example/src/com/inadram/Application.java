package com.inadram;

import com.inadram.service.CustomerService;
import com.inadram.service.CustomerServiceImplementation;

public class Application {
	public static void main(String args[]){
		CustomerService customerService=new CustomerServiceImplementation();
		System.out.println(customerService.findAll().get(0).getFirstName());
	}
}
