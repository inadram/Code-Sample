import com.inadram.repo.CustomerRepository;
import com.inadram.repo.hibernateRepositoryImplementation;
import com.inadram.service.CustomerService;
import com.inadram.service.CustomerServiceImplementation;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Scope;

@Configuration
@ComponentScan({"com.inadram"})
public class AppConfig {

	@Bean(name = "customerService")
//	@Scope("singleton")
	@Scope("prototype")
	public CustomerService getCustomerService() {
		return new CustomerServiceImplementation();
	}

	@Bean(name = "customerRepository")
	public CustomerRepository getCustomerRepository() {
		return new hibernateRepositoryImplementation();
	}
}
