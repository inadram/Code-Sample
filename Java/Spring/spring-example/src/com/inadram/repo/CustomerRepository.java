package com.inadram.repo;

import com.inadram.customer.Customer;

import java.util.List;

public interface CustomerRepository {
	List<Customer> findAll();
}
