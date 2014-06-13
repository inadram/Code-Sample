import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import com.inadram.service.CustomerService;
//import com.inadram.service.CustomerServiceImplementation;


public class Application {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//CustomerService service = new CustomerServiceImplementation();
		
		ApplicationContext appContext = new AnnotationConfigApplicationContext(AppConfig.class);
		
		CustomerService service = appContext.getBean("customerService", CustomerService.class);

		System.out.println(service);

		CustomerService service2 = appContext.getBean("customerService", CustomerService.class);

		System.out.println(service2);
		
		System.out.println(service.findAll().get(0).getFirstName());
	}

}
